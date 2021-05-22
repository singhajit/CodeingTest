using System;
using System.Collections.Generic;
using System.Text;

namespace CodeingTest
{
    interface IPromotions
    {
        int GetTotalPrice(List<PromotionsModel> PromotionsModels);
        void GetPriceByType(string Unit);

        void GetCalculatedUnit(PromotionsModel PromotionsModel, ref int unitofUnit);
    }
}
