using System;
using System.Collections.Generic;
using System.Text;

namespace CodeingTest
{
    public class PromotionsModel : IPromotions
    {
        public string _unit { get; set; }
        public decimal _price { get; set; }
        
        public int GetTotalPrice(List<PromotionsModel> PromotionsModels)
        {
            int UnitOfA = 0;
            int PriceOfA = 50;
            int UnitOfB = 0;
            int PriceOfB = 30;
            int UnitOfC = 0;
            int PriceOfC = 20;
            int UnitOfD = 0;
            int PriveOfD = 15;
            foreach (PromotionsModel pr in PromotionsModels)
            {
                if (pr._unit == "A" || pr._unit == "a")
                {
                    UnitOfA = UnitOfA + 1;
                }
                if (pr._unit == "B" || pr._unit == "b")
                {
                    UnitOfB = UnitOfB + 1;
                }
                if (pr._unit == "C" || pr._unit == "c")
                {
                    UnitOfC = UnitOfC + 1;
                }
                if (pr._unit == "D" || pr._unit == "d")
                {
                    UnitOfD = UnitOfD + 1;
                }
            }
            int TotalPriceOfA = (UnitOfA / 3) * 130 + (UnitOfA % 3 * PriceOfA);
            int TotalPriceOfB = (UnitOfB / 2) * 45 + (UnitOfB % 2 * PriceOfB);
            int TotalPriceOfC = (UnitOfC * PriceOfC);
            int TotalPriceOfD = (UnitOfD * PriveOfD);
            return TotalPriceOfA + TotalPriceOfB + TotalPriceOfC + TotalPriceOfD;
        }

        public void GetPriceByType(string Unit)
        {
            this._unit = Unit;
            switch (_unit)
            {
                case "A":
                case "a":
                    this._price = 50m;

                    break;
                case "B":
                case "b":
                    this._price = 30m;

                    break;
                case "C":
                case "c":
                    this._price = 20m;

                    break;
                case "D":
                    this._price = 2015m;
                    break;
            }
        }
    }
}
