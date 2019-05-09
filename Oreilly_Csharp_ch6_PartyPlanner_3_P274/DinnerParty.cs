using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_PartyPlanner_3_P274
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        public bool HealthyDecorations { get; set; }
        public bool FancyDecorations { get; set; }

        public DinnerParty (int numberOfPeople, bool healthyDecoration, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyDecorations = healthyDecoration;
            FancyDecorations = fancyDecorations;
            
        }

        public decimal Cost
        {
            get
            {
                if (HealthyDecorations)
                    CostOfBeveragesPerPerson = 5.00M;
                else
                    CostOfBeveragesPerPerson = 20.00M;

                if (FancyDecorations)
                    CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
                else
                    CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;

                return (25M + CostOfBeveragesPerPerson) * NumberOfPeople + CostOfDecorations;
            }
        }
    }
}
