using System;
using System.Collections.Generic;
using System.Text;

namespace CodeingTest
{
    public class PromotionsModel
    {
        public string _unit { get; set; }
        public decimal _price { get; set; }

        public PromotionsModel(string Unit)
        {
            this._unit = Unit;
            switch (Unit)
            {
                case "A":
                    this._price = 50m;

                    break;
                case "B":
                    this._price = 30m;

                    break;
                case "C":
                    this._price = 20m;

                    break;
                case "D":
                    this._price = 2015m;
                    break;
            }
        }
    }
}
