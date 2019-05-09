using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_PartyPlanner_3_P274
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }


        public decimal CalculateCostOfDecoration()
        {
                decimal costOfDecorations;
                if (FancyDecorations)
                    costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
                else
                    costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
                return costOfDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                return totalCost;
            }
        }
    }
}
