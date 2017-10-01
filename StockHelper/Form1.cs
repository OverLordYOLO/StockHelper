using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StockHelper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        #region Helper functions

        public void countRiskUnit()
        {
            double capital;
            Double.TryParse(capitalTextBox.Text, out capital);

            if (capital == 0)
            {
                capitalTextBox.BackColor = Color.MediumVioletRed;
            }
            else
            {
                capitalTextBox.BackColor = Color.White;
            }

            riskTextBox.Text = UIInteractions.countRisk(capital, riskPercentageNumericUpDown.Value).ToString();
        }

        public Settings createSettings(Currency currency)
        {
            double capital = 0;
            try
            {
                double.TryParse(capitalTextBox.Text, out capital);

                if (capital == 0)
                {
                    throw new Exception("Invalid Capital");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                throw;
            }

            Settings settings = new Settings();
            if (Currency.USD == currency)
            {
                settings.commissionPercentageUSD = (double)commissionsPercentageNumericUpDown.Value;
                settings.commissionPerShareUSD = (double)commissionsPerShareNumericUpDown.Value;
                settings.commissionPerTradeUSD = (double)commissionsPerTradeNumericUpDown.Value;

                settings.commissionMinPerTradeUSD = (double)commissionsMinPerTradeNumericUpDown.Value;
                settings.commissionMinPerTrade_percentage_CurrencyUSD = (minimumPerTradePercentageRadioButton.Checked ? 1 : 0);
                settings.commissionMaxPerTradeUSD = (double)commissionsMaxPerTradeNumericUpDown.Value;
                settings.commissionMaxPerTrade_percentage_CurrencyUSD = (maximumPerTradePercentageRadioButton.Checked ? 1 : 0);

                settings.capitalUSD = capital;
                settings.riskPercentageUSD = (double)riskPercentageNumericUpDown.Value;
            }
            else if (Currency.EUR == currency)
            {

                settings.commissionPercentageEUR = (double)commissionsPercentageNumericUpDown.Value;
                settings.commissionPerShareEUR = (double)commissionsPerShareNumericUpDown.Value;
                settings.commissionPerTradeEUR = (double)commissionsPerTradeNumericUpDown.Value;

                settings.commissionMinPerTradeEUR = (double)commissionsMinPerTradeNumericUpDown.Value;
                settings.commissionMinPerTrade_percentage_CurrencyEUR = (minimumPerTradePercentageRadioButton.Checked ? 1 : 0);
                settings.commissionMaxPerTradeEUR = (double)commissionsMaxPerTradeNumericUpDown.Value;
                settings.commissionMaxPerTrade_percentage_CurrencyEUR = (maximumPerTradePercentageRadioButton.Checked ? 1 : 0);

                settings.capitalEUR = capital;
                settings.riskPercentageEUR = (double)riskPercentageNumericUpDown.Value;
            }
            else if (Currency.CZK == currency)
            {

                settings.commissionPercentageCZK = (double)commissionsPercentageNumericUpDown.Value;
                settings.commissionPerShareCZK = (double)commissionsPerShareNumericUpDown.Value;
                settings.commissionPerTradeCZK = (double)commissionsPerTradeNumericUpDown.Value;

                settings.commissionMinPerTradeCZK = (double)commissionsMinPerTradeNumericUpDown.Value;
                settings.commissionMinPerTrade_percentage_CurrencyCZK = (minimumPerTradePercentageRadioButton.Checked ? 1 : 0);
                settings.commissionMaxPerTrade_percentage_CurrencyCZK = (maximumPerTradePercentageRadioButton.Checked ? 1 : 0);
                settings.commissionMaxPerTradeCZK = (double)commissionsMaxPerTradeNumericUpDown.Value;

                settings.capitalCZK = capital;
                settings.riskPercentageCZK = (double)riskPercentageNumericUpDown.Value;
            }
            return settings;
        }

        public void saveSettings(Currency currency)
        {
            try
            {
                Settings settings = createSettings(currency);

                UIInteractions.saveSettings(settings, currency);

                capitalTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                capitalTextBox.BackColor = Color.MediumVioletRed;
            }
        }

        public void loadSettings(Settings settings, Currency currency)
        {
            if (currency == Currency.USD)
            {
                commissionsPercentageNumericUpDown.Value = (decimal)settings.commissionPercentageUSD;
                commissionsPerShareNumericUpDown.Value = (decimal)settings.commissionPerShareUSD;
                commissionsPerTradeNumericUpDown.Value = (decimal)settings.commissionPerTradeUSD;

                commissionsMaxPerTradeNumericUpDown.Value = (decimal)settings.commissionMinPerTradeUSD;
                if (settings.commissionMinPerTrade_percentage_CurrencyUSD == 1)
                { minimumPerTradePercentageRadioButton.Checked = true; }
                else { minimumPerTradeCurrencyRadioButton.Checked = true; }

                commissionsMinPerTradeNumericUpDown.Value = (decimal)settings.commissionMaxPerTradeUSD;
                if (settings.commissionMaxPerTrade_percentage_CurrencyUSD == 1)
                { maximumPerTradePercentageRadioButton.Checked = true; }
                else { maximumPerTradeCurrencyRadioButton.Checked = true; }

                capitalTextBox.Text = settings.capitalUSD.ToString();
                riskPercentageNumericUpDown.Value = (decimal)settings.riskPercentageUSD;

            }
            else if (currency == Currency.EUR)
            {
                commissionsPercentageNumericUpDown.Value = (decimal)settings.commissionPercentageEUR;
                commissionsPerShareNumericUpDown.Value = (decimal)settings.commissionPerShareEUR;
                commissionsPerTradeNumericUpDown.Value = (decimal)settings.commissionPerTradeEUR;

                commissionsMaxPerTradeNumericUpDown.Value = (decimal)settings.commissionMinPerTradeEUR;
                if (settings.commissionMinPerTrade_percentage_CurrencyEUR == 1)
                { minimumPerTradePercentageRadioButton.Checked = true; }
                else { minimumPerTradeCurrencyRadioButton.Checked = true; }

                commissionsMinPerTradeNumericUpDown.Value = (decimal)settings.commissionMaxPerTradeEUR;
                if (settings.commissionMaxPerTrade_percentage_CurrencyEUR == 1)
                { maximumPerTradePercentageRadioButton.Checked = true; }
                else { maximumPerTradeCurrencyRadioButton.Checked = true; }

                capitalTextBox.Text = settings.capitalEUR.ToString();
                riskPercentageNumericUpDown.Value = (decimal)settings.riskPercentageEUR;
            }
            else if (currency == Currency.CZK)
            {
                commissionsPercentageNumericUpDown.Value = (decimal)settings.commissionPercentageCZK;
                commissionsPerShareNumericUpDown.Value = (decimal)settings.commissionPerShareCZK;
                commissionsPerTradeNumericUpDown.Value = (decimal)settings.commissionPerTradeCZK;

                commissionsMaxPerTradeNumericUpDown.Value = (decimal)settings.commissionMaxPerTradeCZK;
                if (settings.commissionMinPerTrade_percentage_CurrencyCZK == 1)
                { minimumPerTradePercentageRadioButton.Checked = true; }
                else { minimumPerTradeCurrencyRadioButton.Checked = true; }

                commissionsMinPerTradeNumericUpDown.Value = (decimal)settings.commissionMinPerTradeCZK;
                if (settings.commissionMaxPerTrade_percentage_CurrencyCZK == 1)
                { maximumPerTradePercentageRadioButton.Checked = true; }
                else { maximumPerTradeCurrencyRadioButton.Checked = true; }

                capitalTextBox.Text = settings.capitalCZK.ToString();
                riskPercentageNumericUpDown.Value = (decimal)settings.riskPercentageCZK;
            }
        }

        public void emptyCells()
        {
            takeProfitTextBox.Text = sharePriceTextBox.Text = stopLossTextBox.Text =
                riskRewardTextBox.Text = numberOfSharesTextBox.Text = finalPriceTextBox.Text =
                gainTextBox.Text = riskingTextBox.Text = "";
        }

        public static void setZeroToNanOrZero(TextBox sender)
        {
            double number;
            double.TryParse(sender.Text, out number);

            if (number == 0)
            {
                sender.Text = "0";
            }
        }
        public static void setZeroToNanOrZero(RichTextBox sender)
        {
            double number;
            double.TryParse(sender.Text, out number);

            if (number == 0)
            {
                sender.Text = "0";
            }
        }

        public static double getDoubleFromTextBox(TextBox window)
        {
            double number;
            double.TryParse(window.Text, out number);
            return number;
        }
        public static double getDoubleFromTextBox(RichTextBox window)
        {
            double number;
            double.TryParse(window.Text, out number);
            return number;
        }

        #region Move window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #endregion

        #region EventHandlers

        private void setUsdButton_Click(object sender, EventArgs e)
        {
            saveSettings(Currency.USD);
            currencyLabel.Text = "USD";
        }

        private void setEurButton_Click(object sender, EventArgs e)
        {
            saveSettings(Currency.EUR);
            currencyLabel.Text = "EUR";
        }

        private void setCzkButton_Click(object sender, EventArgs e)
        {
            saveSettings(Currency.CZK);
            currencyLabel.Text = "CZK";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capitalTextBox_TextChanged(object sender, EventArgs e)
        {
            countRiskUnit();
        }

        private void riskPercentageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            countRiskUnit();
        }

        private void loadCzkbutton_Click(object sender, EventArgs e)
        {
            try
            {
                loadSettings(UIInteractions.loadSettings(), Currency.CZK);
                currencyLabel.Text = "CZK";
            }
            catch (Exception)
            {

            }
        }

        private void loadEurbutton_Click(object sender, EventArgs e)
        {
            try
            {
                loadSettings(UIInteractions.loadSettings(), Currency.EUR);
            currencyLabel.Text = "EUR";
            }
            catch (Exception)
            {

            }
        }

        private void loadUsdbutton_Click(object sender, EventArgs e)
        {
            try
            {
                loadSettings(UIInteractions.loadSettings(), Currency.USD);
            currencyLabel.Text = "USD";
        }
            catch (Exception)
            {

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            emptyCells();
        }


        private void countButton_Click(object sender, EventArgs e)
        {

            count();

            /*
            double riskUnit;
            double.TryParse(riskTextBox.Text, out riskUnit);







            if (riskUnit == 0)
            {
                MessageBox.Show("1R has to be bigger than 0.");
                oneRLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                oneRLabel.ForeColor = Color.White;
            }






            double takeProfit;
            double.TryParse(takeProfitTextBox.Text, out takeProfit);

            double price;
            double.TryParse(sharePriceTextBox.Text, out price);

            if (takeProfit == 0)
            {
                takeProfitLabel.ForeColor = riskRewardLabel.ForeColor = gainLabel.ForeColor = Color.Red;
            }
            else if(takeProfit <= price)
            {
                takeProfitLabel.ForeColor = Color.Red;
                MessageBox.Show("Take Profit has to be higher than price,\nor nothing.");
                return;
            }
            else
            {
                takeProfitLabel.ForeColor = riskRewardLabel.ForeColor = gainLabel.ForeColor = Color.White;
            }




            /*
            double riskUnitNumber;
            double.TryParse(riskTextBox.Text, out riskUnitNumber);

            double stopLossNumber;
            double.TryParse(stopLossTextBox.Text, out stopLossNumber);

            double takeProfitNumber;
            double.TryParse(takeProfitTextBox.Text, out takeProfitNumber);



            int numberOfShares = (int)Math.Floor((riskUnitNumber / (price - stopLossNumber)));
            double finalPrice = numberOfShares * price;

            int gain = (int)Math.Floor((takeProfitNumber - price) * numberOfShares);

            int risk = (int)Math.Floor((price - stopLossNumber) * numberOfShares);

            double riskReward = ((price - stopLossNumber) * numberOfShares) / ((takeProfitNumber - price) * numberOfShares);

            riskRewardTextBox.Text = riskReward.ToString();

            gainTextBox.Text = gain.ToString();

            riskingTextBox.Text = risk.ToString();

            numberOfSharesTextBox.Text = numberOfShares.ToString();
            finalPriceTextBox.Text = finalPrice.ToString();
            */


        }

        private void sharePriceTextBox_Leave(object sender, EventArgs e)
        {
            setZeroToNanOrZero((RichTextBox)sender);
        }

        private void stopLossTextBox_Leave(object sender, EventArgs e)
        {

            setZeroToNanOrZero((RichTextBox)sender);
        }

        private void takeProfitTextBox_Leave(object sender, EventArgs e)
        {
            setZeroToNanOrZero((RichTextBox)sender);
        }

        private void capitalTextBox_Leave(object sender, EventArgs e)
        {
            setZeroToNanOrZero((TextBox)sender);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) emptyCells();
            else if (e.KeyCode == Keys.Enter) count();
        }

        #endregion



        private void testButton_Click(object sender, EventArgs e)
        {
            takeProfitTextBox.Text = "100";
            sharePriceTextBox.Text = "90";
            stopLossTextBox.Text = "80";

        }

        private void count()
        {


            double takeProfit = getDoubleFromTextBox(takeProfitTextBox);
            double sharePrice = getDoubleFromTextBox(sharePriceTextBox);
            double stopLoss = getDoubleFromTextBox(stopLossTextBox);

            double commissionsPercentage = (double)commissionsPercentageNumericUpDown.Value;
            double commissionsPerShare = (double)commissionsPerShareNumericUpDown.Value;
            double commissionsPerTrade = (double)commissionsPerTradeNumericUpDown.Value;

            double commissionsMinPerTrade = (double)commissionsMinPerTradeNumericUpDown.Value;
            bool commissionsMinPerTradePercentage = minimumPerTradePercentageRadioButton.Checked;
            double commissionsMaxPerTrade = (double)commissionsMaxPerTradeNumericUpDown.Value;
            bool commissionsMaxPerTradePercentage = maximumPerTradePercentageRadioButton.Checked;

            double riskUnit = getDoubleFromTextBox(riskTextBox);

            double capital = getDoubleFromTextBox(capitalTextBox);

            Info info = new Info(takeProfit, sharePrice, stopLoss, commissionsPercentage,
                commissionsPerShare, commissionsPerTrade, commissionsMinPerTrade,
                commissionsMinPerTradePercentage, commissionsMaxPerTrade, commissionsMaxPerTradePercentage,
                riskUnit, capital);

            Result result = UIInteractions.mainCount(info);

            riskRewardTextBox.Text = result.riskReward.ToString();
            numberOfSharesTextBox.Text = result.numberOfShares.ToString();
            finalPriceTextBox.Text = result.finalPrice.ToString();
            gainTextBox.Text = result.gain.ToString();
            riskingTextBox.Text = result.risking.ToString();





        }


    }
}
