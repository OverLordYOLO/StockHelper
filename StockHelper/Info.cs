using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHelper
{
    struct Info
    {
        public double takeProfit { get; private set; }
        public double sharePrice { get; private set; }
        public double stopLoss { get; private set; }

        public double commissionsPercentage { get; private set; }
        public double commissionsPerShare { get; private set; }
        public double commissionsPerTrade { get; private set; }

        public double commissionsMinPerTrade { get; private set; }
        public bool commissionsMinPerTradePercentage { get; private set; }
        public double commissionsMaxPerTrade { get; private set; }
        public bool commissionsMaxPerTradePercentage { get; private set; }

        public double riskUnit { get; private set; }

        public double capital { get; private set; }


        public Info(double tempTakeProfit, double tempSharePrice, double tempStopLoss, 
            double tempCommissionsPercentage, double tempCommissionsPerShare, double tempCommissionsPerTrade, 
            double tempCommissionsMinPerTrade, bool tempCommissionsMinPerTradePercentage, 
            double tempCommissionsMaxPerTrade, bool tempCommissionsMaxPerTradePercentage,
            double tempRiskUnit, double tempCapital)
        {
            takeProfit = tempTakeProfit;
            sharePrice = tempSharePrice;
            stopLoss = tempStopLoss;

            commissionsPercentage = tempCommissionsPercentage;
            commissionsPerShare = tempCommissionsPerShare;
            commissionsPerTrade = tempCommissionsPerTrade;

            commissionsMinPerTrade = tempCommissionsMinPerTrade;
            commissionsMinPerTradePercentage = tempCommissionsMinPerTradePercentage;
            commissionsMaxPerTrade = tempCommissionsMaxPerTrade;
            commissionsMaxPerTradePercentage = tempCommissionsMaxPerTradePercentage;

            riskUnit = tempRiskUnit;

            capital = tempCapital;
        }
        
    }
}
