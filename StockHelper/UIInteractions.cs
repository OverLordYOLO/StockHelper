using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockHelper
{
    static class UIInteractions
    {
        private static string settingsFilePath()
        {
            
            return Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.ApplicationData), "StockHelper\\Settings.xml");

            
            //return "settings.xml";
        }

        public static Settings loadSettings()
        {
            SettingsLoad settingsLoad = new SettingsLoad();

            Settings loadedSettings = settingsLoad.loadSettings(settingsFilePath());

            return loadedSettings;
        }


        public static void saveSettings(Settings settings, Currency currency)
        {
            if (File.Exists(settingsFilePath()))
            {
                SettingsLoad settingsLoad = new SettingsLoad();

                Settings loadedSettings = settingsLoad.loadSettings(settingsFilePath());
                settings = Settings.Merge(currency, settings, loadedSettings);
            }
            SettingsSave settingsSave = new SettingsSave();

            settingsSave.saveSettings(settings, settingsFilePath());
        }

        public static double countRisk(double capital, decimal riskPercentageOfCapital)
        {
            double riskPercentageOfCapitalDouble;
            double.TryParse(riskPercentageOfCapital.ToString(), out riskPercentageOfCapitalDouble);

            return (double)((capital / 100) * riskPercentageOfCapitalDouble);
        }

        internal static Result mainCount(Info info)
        {
            double riskReward = 0;
            int numberOfShares = 0;
            double finalPrice = 0;

            double gain = 0;
            double risking = 0;

            numberOfShares = countNumberOfShares(info);

            finalPrice = (info.sharePrice * numberOfShares) + countCommissions(info, numberOfShares, 0);

            gain = (info.takeProfit * numberOfShares) - countCommissions(info, numberOfShares, 1) - finalPrice;

            risking = (info.stopLoss * numberOfShares) - countCommissions(info, numberOfShares, -1) - finalPrice;

            riskReward = -risking / gain;


            return new Result(riskReward, numberOfShares, finalPrice, gain, risking);
            
        }

        private static int countNumberOfShares(Info info)
        {
            int numberOfShares;

            numberOfShares = (int)Math.Floor((info.riskUnit / (info.sharePrice - info.stopLoss)));

            numberOfShares = findGoodAmount(info, numberOfShares);



            return numberOfShares;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="way">1, 0, -1 (take profit, sharePrice, stop-loss)</param>
        /// <param name="numberOfShares"></param>
        /// <returns></returns>
        private static double countCommissions(Info info, int numberOfShares, int way = 0)
        {
            if (way != 1 && way != 0 && way != -1) throw new Exception("countCommissions bad way.");

            double commission = 0;

            double comPercentage = 0;
            double comPerShare = 0;
            double comPerTrade = 0;


            if (way == 1)
            {
                if (info.commissionsPercentage > 0)
                {
                    comPercentage = (numberOfShares * info.takeProfit) / 100 * info.commissionsPercentage;
                    commission += comPercentage;
                }
                if (info.commissionsPerShare > 0)
                {
                    comPerShare = (numberOfShares * info.commissionsPerShare);
                    commission += comPerShare;
                }
                if (info.commissionsPerTrade > 0)
                {
                    comPerTrade = info.commissionsPerTrade;
                    commission += comPerTrade;
                }
            }
            if (way == 0)
            {
                if (info.commissionsPercentage > 0)
                {
                    comPercentage = (numberOfShares * info.sharePrice) / 100 * info.commissionsPercentage;
                    commission += comPercentage;
                }
                if (info.commissionsPerShare > 0)
                {
                    comPerShare = (numberOfShares * info.commissionsPerShare);
                    commission += comPerShare;
                }
                if (info.commissionsPerTrade > 0)
                {
                    comPerTrade = info.commissionsPerTrade;
                    commission += comPerTrade;
                }
            }
            if (way == -1)
            {
                if (info.commissionsPercentage > 0)
                {
                    comPercentage = (numberOfShares * info.stopLoss) / 100 * info.commissionsPercentage;
                    commission += comPercentage;
                }
                if (info.commissionsPerShare > 0)
                {
                    comPerShare = (numberOfShares * info.commissionsPerShare);
                    commission += comPerShare;
                }
                if (info.commissionsPerTrade > 0)
                {
                    comPerTrade = info.commissionsPerTrade;
                    commission += comPerTrade;
                }
            }




            if (info.commissionsMinPerTradePercentage)
            {
                if (commission < ((numberOfShares * info.commissionsPerShare) / 100 * info.commissionsMinPerTrade))
                {
                    commission = ((numberOfShares * info.commissionsPerShare) / 100 * info.commissionsMinPerTrade);
                }
            }
            else
            {
                if (commission < info.commissionsMinPerTrade)
                {
                    commission = info.commissionsMinPerTrade;
                }
            }

            if (info.commissionsMaxPerTradePercentage)
            {
                if (commission > ((numberOfShares * info.commissionsPerShare) / 100 * info.commissionsMaxPerTrade))
                {
                    commission = ((numberOfShares * info.commissionsPerShare) / 100 * info.commissionsMaxPerTrade);
                }
            }
            else
            {
                if (commission > info.commissionsMaxPerTrade)
                {
                    commission = info.commissionsMaxPerTrade;
                }
            }

            return commission;
        }

        private static int findGoodAmount(Info info, int tempNumberOfShares)
        {
            int numberOfShares = 0;
            numberOfShares = tempNumberOfShares;
            if (((numberOfShares * (info.sharePrice - info.stopLoss) + countCommissions(info, numberOfShares)) > info.riskUnit) || (numberOfShares*info.sharePrice + countCommissions(info, numberOfShares)) > info.capital - 1000)
            {

                if (numberOfShares <= 1)
                {
                    return 0;
                }
                else
                {
                    numberOfShares = findGoodAmount(info, numberOfShares - 1);
                }

            }

            return numberOfShares;
        }
    }
}
