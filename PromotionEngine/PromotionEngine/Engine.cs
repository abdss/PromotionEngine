using System;

namespace PromotionEngine
{
    public class Engine
    {
        var priceA = 50;
        var priceB = 30;
        var priceC = 20;
        var priceD = 15;

        var promoQuantityA = 3;
        var promoQuantityB = 2;

        var promoPriceA = 130;
        var promoPriceB = 45;
        var promoPriceCD = 30;

        public int CalculateOrderValue(int quantityA, int quantityB, int quantityC, int quantityD)
        {
            var total = 0;

            total += ApplyPromotion(quantityA, priceA, promoQuantityA, promoPriceA);

            total += ApplyPromotion(quantityB, priceB, promoQuantityB, promoPriceB);

            total += ApplyCDPromotion(quantityC, quantityD, promoPriceCD);
            
            return total;
        }

        private int ApplyPromotion(int quantityA, int priceA, int promoQuantityA, int promoPriceA)
        {

        }

        private int ApplyCDPromotion(int quantityC, int quantityD, int promoPriceCD)
        {

        }
    }
}
