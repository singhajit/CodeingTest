using System;
using System.Collections.Generic;

namespace CodeingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<PromotionsModel> _promotionsModels = new List<PromotionsModel>();
            int _totalPrice = 0;
            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                PromotionsModel promotionsModel = new PromotionsModel();
                promotionsModel.GetPriceByType(type);
                _promotionsModels.Add(promotionsModel);

                _totalPrice = promotionsModel.GetTotalPrice(_promotionsModels);
            }

            Console.WriteLine(_totalPrice);
            Console.ReadLine();

        }
    }
}
