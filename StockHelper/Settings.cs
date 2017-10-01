using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StockHelper
{
    public enum Currency { USD, EUR, CZK };
    [XmlRoot]
    public class Settings
    {


        // Bottom part (commissions)

        //USD
        public double commissionPercentageUSD;
        public double commissionPerShareUSD;
        public double commissionPerTradeUSD;

        public double commissionMaxPerTradeUSD;
        public int commissionMaxPerTrade_percentage_CurrencyUSD;
        public double commissionMinPerTradeUSD;
        public int commissionMinPerTrade_percentage_CurrencyUSD;

        public double capitalUSD;
        public double riskPercentageUSD;

        //EUR
        public double commissionPercentageEUR;
        public double commissionPerShareEUR;
        public double commissionPerTradeEUR;

        public double commissionMaxPerTradeEUR;
        public int commissionMaxPerTrade_percentage_CurrencyEUR;
        public double commissionMinPerTradeEUR;
        public int commissionMinPerTrade_percentage_CurrencyEUR;

        public double capitalEUR;
        public double riskPercentageEUR;

        //CZK
        public double commissionPercentageCZK;
        public double commissionPerShareCZK;
        public double commissionPerTradeCZK;

        public double commissionMaxPerTradeCZK;
        public int commissionMaxPerTrade_percentage_CurrencyCZK;
        public double commissionMinPerTradeCZK;
        public int commissionMinPerTrade_percentage_CurrencyCZK;

        public double capitalCZK;
        public double riskPercentageCZK;




        internal static Settings Merge(Currency currency, Settings settings, Settings loadedSettings)
        {
            Settings merged = new Settings();

            if (currency == Currency.USD)
            {
                //USD
                merged.commissionPercentageUSD = settings.commissionPercentageUSD;
                merged.commissionPerShareUSD = settings.commissionPerShareUSD;
                merged.commissionPerTradeUSD = settings.commissionPerTradeUSD;

                merged.commissionMaxPerTradeUSD = settings.commissionMaxPerTradeUSD;
                merged.commissionMaxPerTrade_percentage_CurrencyUSD = settings.commissionMaxPerTrade_percentage_CurrencyUSD;
                merged.commissionMinPerTradeUSD = settings.commissionMinPerTradeUSD;
                merged.commissionMinPerTrade_percentage_CurrencyUSD = settings.commissionMinPerTrade_percentage_CurrencyUSD;
         
                merged.capitalUSD = settings.capitalUSD;
                merged.riskPercentageUSD = settings.riskPercentageUSD;

                //EUR
                merged.commissionPercentageEUR = loadedSettings.commissionPercentageEUR;
                merged.commissionPerShareEUR = loadedSettings.commissionPerShareEUR;
                merged.commissionPerTradeEUR = loadedSettings.commissionPerTradeEUR;

                merged.commissionMaxPerTradeEUR = loadedSettings.commissionMaxPerTradeEUR;
                merged.commissionMaxPerTrade_percentage_CurrencyEUR = loadedSettings.commissionMaxPerTrade_percentage_CurrencyEUR;
                merged.commissionMinPerTradeEUR = loadedSettings.commissionMinPerTradeEUR;
                merged.commissionMinPerTrade_percentage_CurrencyEUR = loadedSettings.commissionMinPerTrade_percentage_CurrencyEUR;

                merged.capitalEUR = loadedSettings.capitalEUR;
                merged.riskPercentageEUR = loadedSettings.riskPercentageEUR;

                //CZK
                merged.commissionPercentageCZK = loadedSettings.commissionPercentageCZK;
                merged.commissionPerShareCZK = loadedSettings.commissionPerShareCZK;
                merged.commissionPerTradeCZK = loadedSettings.commissionPerTradeCZK;

                merged.commissionMaxPerTradeCZK = loadedSettings.commissionMaxPerTradeCZK;
                merged.commissionMaxPerTrade_percentage_CurrencyCZK = loadedSettings.commissionMaxPerTrade_percentage_CurrencyCZK;
                merged.commissionMinPerTradeCZK = loadedSettings.commissionMinPerTradeCZK;
                merged.commissionMinPerTrade_percentage_CurrencyCZK = loadedSettings.commissionMinPerTrade_percentage_CurrencyCZK;

                merged.capitalCZK = loadedSettings.capitalCZK;
                merged.riskPercentageCZK = loadedSettings.riskPercentageCZK;
            }
            else if (currency == Currency.EUR)
            {
                //EUR
                merged.commissionPercentageEUR = settings.commissionPercentageEUR;
                merged.commissionPerShareEUR = settings.commissionPerShareEUR;
                merged.commissionPerTradeEUR = settings.commissionPerTradeEUR;
               
                merged.commissionMaxPerTradeEUR = settings.commissionMaxPerTradeEUR;
                merged.commissionMaxPerTrade_percentage_CurrencyEUR = settings.commissionMaxPerTrade_percentage_CurrencyEUR;
                merged.commissionMinPerTradeEUR = settings.commissionMinPerTradeEUR;
                merged.commissionMinPerTrade_percentage_CurrencyEUR = settings.commissionMinPerTrade_percentage_CurrencyEUR;
            
                merged.capitalEUR = settings.capitalEUR;
                merged.riskPercentageEUR = settings.riskPercentageEUR;


                //USD
                merged.commissionPercentageUSD = loadedSettings.commissionPercentageUSD;
                merged.commissionPerShareUSD = loadedSettings.commissionPerShareUSD;
                merged.commissionPerTradeUSD = loadedSettings.commissionPerTradeUSD;

                merged.commissionMaxPerTradeUSD = loadedSettings.commissionMaxPerTradeUSD;
                merged.commissionMaxPerTrade_percentage_CurrencyUSD = loadedSettings.commissionMaxPerTrade_percentage_CurrencyUSD;
                merged.commissionMinPerTradeUSD = loadedSettings.commissionMinPerTradeUSD;
                merged.commissionMinPerTrade_percentage_CurrencyUSD = loadedSettings.commissionMinPerTrade_percentage_CurrencyUSD;

                merged.capitalUSD = loadedSettings.capitalUSD;
                merged.riskPercentageUSD = loadedSettings.riskPercentageUSD;

                // CZK
                merged.commissionPercentageCZK = loadedSettings.commissionPercentageCZK;
                merged.commissionPerShareCZK = loadedSettings.commissionPerShareCZK;
                merged.commissionPerTradeCZK = loadedSettings.commissionPerTradeCZK;

                merged.commissionMaxPerTradeCZK = loadedSettings.commissionMaxPerTradeCZK;
                merged.commissionMaxPerTrade_percentage_CurrencyCZK = loadedSettings.commissionMaxPerTrade_percentage_CurrencyCZK;
                merged.commissionMinPerTradeCZK = loadedSettings.commissionMinPerTradeCZK;
                merged.commissionMinPerTrade_percentage_CurrencyCZK = loadedSettings.commissionMinPerTrade_percentage_CurrencyCZK;

                merged.capitalCZK = loadedSettings.capitalCZK;
                merged.riskPercentageCZK = loadedSettings.riskPercentageCZK;
            }
            else
            {
                //CZK
                merged.commissionPercentageCZK = settings.commissionPercentageCZK;
                merged.commissionPerShareCZK = settings.commissionPerShareCZK;
                merged.commissionPerTradeCZK = settings.commissionPerTradeCZK;

                merged.commissionMaxPerTradeCZK = settings.commissionMaxPerTradeCZK;
                merged.commissionMaxPerTrade_percentage_CurrencyCZK = settings.commissionMaxPerTrade_percentage_CurrencyCZK;
                merged.commissionMinPerTradeCZK = settings.commissionMinPerTradeCZK;
                merged.commissionMinPerTrade_percentage_CurrencyCZK = loadedSettings.commissionMinPerTrade_percentage_CurrencyCZK;

                merged.capitalCZK = settings.capitalCZK;
                merged.riskPercentageCZK = settings.riskPercentageCZK;

                //USD
                merged.commissionPercentageUSD = loadedSettings.commissionPercentageUSD;
                merged.commissionPerShareUSD = loadedSettings.commissionPerShareUSD;
                merged.commissionPerTradeUSD = loadedSettings.commissionPerTradeUSD;

                merged.commissionMaxPerTradeUSD = loadedSettings.commissionMaxPerTradeUSD;
                merged.commissionMaxPerTrade_percentage_CurrencyUSD = loadedSettings.commissionMaxPerTrade_percentage_CurrencyUSD;
                merged.commissionMinPerTradeUSD = loadedSettings.commissionMinPerTradeUSD;
                merged.commissionMinPerTrade_percentage_CurrencyUSD = loadedSettings.commissionMinPerTrade_percentage_CurrencyUSD;

                merged.capitalUSD = loadedSettings.capitalUSD;
                merged.riskPercentageUSD = loadedSettings.riskPercentageUSD;

                // EUR
                merged.commissionPercentageEUR = loadedSettings.commissionPercentageEUR;
                merged.commissionPerShareEUR = loadedSettings.commissionPerShareEUR;
                merged.commissionPerTradeEUR = loadedSettings.commissionPerTradeEUR;

                merged.commissionMaxPerTradeEUR = loadedSettings.commissionMaxPerTradeEUR;
                merged.commissionMaxPerTrade_percentage_CurrencyEUR = loadedSettings.commissionMaxPerTrade_percentage_CurrencyEUR;
                merged.commissionMinPerTradeEUR = loadedSettings.commissionMinPerTradeEUR;
                merged.commissionMinPerTrade_percentage_CurrencyEUR = loadedSettings.commissionMinPerTrade_percentage_CurrencyEUR;

                merged.capitalEUR = loadedSettings.capitalEUR;
                merged.riskPercentageEUR = loadedSettings.riskPercentageEUR;
            }

            return merged;
        }

    }
}
