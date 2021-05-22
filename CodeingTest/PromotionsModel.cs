using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeingTest
{
    public class PromotionsModel : IPromotions
    {
        private string[] unitPermotionList;

        public string _unit { get; set; }
        public decimal _price { get; set; }

        
        public int GetTotalPrice(List<PromotionsModel> PromotionsModels)
        {
            int UnitOfCharCount = 0;
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
                GetCalculatedUnit(pr, ref UnitOfCharCount);

                if (pr._unit == "A" || pr._unit == "a")
                {
                    if (UnitOfCharCount == 0)
                        UnitOfA = UnitOfA + 1;
                    else
                        UnitOfA = UnitOfCharCount;
                }
                if (pr._unit == "B" || pr._unit == "b")
                {
                    if (UnitOfCharCount == 0)
                        UnitOfB = UnitOfB + 1;
                    else
                        UnitOfB = UnitOfCharCount;
                }
                if (pr._unit == "C" || pr._unit == "c")
                {
                    if (UnitOfCharCount == 0)
                        UnitOfC = UnitOfC + 1;
                    else
                        UnitOfC = UnitOfCharCount;
                }
                if (pr._unit == "D" || pr._unit == "d")
                {
                    if (UnitOfCharCount == 0)
                        UnitOfD = UnitOfD + 1;
                    else
                        UnitOfD = UnitOfCharCount;
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

        public void GetCalculatedUnit(PromotionsModel PromotionsModel, ref int unitofUnit)
        {
            int number = 0;
            string[] unitPermotionList = PromotionsModel._unit.Split(",");
            foreach (string unitPermotion in unitPermotionList)
            {
                bool isNumeric = Regex.IsMatch(unitPermotion, @"^\d+$");

                if (!isNumeric)
                    PromotionsModel._unit = unitPermotion;
                else
                    unitofUnit = Convert.ToInt32(unitPermotion);
            }
            //return unitofUnit;
        }
    }
}
