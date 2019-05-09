using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_PartyPlanner_3_P274
{
    class DinnerParty: Party
    {
        public bool HealthyOption { get; set; }
        public DinnerParty(int numberOfPeople, bool healthyDecoration, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyDecoration;
        }


        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerperson;
            if (HealthyOption)
                costOfBeveragesPerperson = 5.00M;
            else
                costOfBeveragesPerperson = 20.00M;
            return costOfBeveragesPerperson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                if (HealthyOption)
                    totalCost *= .95M;
                return totalCost;
            }
        }
    }
}
