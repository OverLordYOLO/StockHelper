using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHelper
{
    struct Result
    {
        public double riskReward { get; private set; }
        public int numberOfShares { get; private set; }
        public double finalPrice { get; private set; }

        public double gain { get; private set; }
        public double risking { get; private set; }

        public Result(double tempRiskReward, int tempNumberOfShares, double tempFinalPrice,
            double tempGain, double tempRisking)
        {
            riskReward = tempRiskReward;
            numberOfShares = tempNumberOfShares;
            finalPrice = tempFinalPrice;

            gain = tempGain;
            risking = tempRisking;
        }
    }
}
