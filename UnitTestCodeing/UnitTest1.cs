using CodeingTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestCodeing
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void TestInit()
        {
            List<PromotionsModel> Fack_promotionsModels = new List<PromotionsModel>
            {
                new PromotionsModel { _unit = "A", _price = 50M },
                new PromotionsModel {_unit = "B", _price = 30M },
                new PromotionsModel {_unit = "C", _price = 20M },
            };

            List<PromotionsModel> Fack_promotionsModelsWithWrongPriceComapir = new List<PromotionsModel>
            {
                new PromotionsModel { _unit = "A", _price = 50M },
                new PromotionsModel {_unit = "B", _price = 30M },
                new PromotionsModel {_unit = "C", _price = 30M },
            };
        }

        [TestMethod]
        public void PromotionsModels_With_ValueOfCorrectUnit()
        {
            PromotionsModel promotionsModelObj = new PromotionsModel();
            var result = promotionsModelObj.GetTotalPrice(Fack_promotionsModels);
            Assert.AreEqual(100, result);
        }

        public void PromotionsModels_With_ValueOfWrongprice()
        {
            PromotionsModel promotionsModelObj = new PromotionsModel();
            var result = promotionsModelObj.GetTotalPrice(Fack_promotionsModelsWithWrongPriceComapir);
            Assert.AreNotEqual(100, result);
        }
    }
}
