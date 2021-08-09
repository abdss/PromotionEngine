using System;

namespace PromotionEngine
{
    public class Engine
    {
        int priceA = 50;
        int priceB = 30;
        int priceC = 20;
        int priceD = 15;

        int promoQuantityA = 3;
        int promoQuantityB = 2;

        int promoPriceA = 130;
        int promoPriceB = 45;
        int promoPriceCD = 30;

        public int CalculateOrderValue(int quantityA, int quantityB, int quantityC, int quantityD)
        {
            var total = 0;

            total += ApplyPromotion(quantityA, priceA, promoQuantityA, promoPriceA);

            total += ApplyPromotion(quantityB, priceB, promoQuantityB, promoPriceB);

            total += ApplyCDPromotion(quantityC, quantityD, priceC, priceD, promoPriceCD);
            
            return total;
        }

        private int ApplyPromotion(int quantityA, int priceA, int promoQuantityA, int promoPriceA)
        {

        }

        private int ApplyCDPromotion(int quantityC, int quantityD, int priceC, int priceD, int promoPriceCD)
        {

        }
    }
}
