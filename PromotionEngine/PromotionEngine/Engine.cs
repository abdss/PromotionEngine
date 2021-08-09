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

            total += ApplyPromotion(quantityA);

            total += ApplyPromotion(quantityA);

            total += ApplyCDPromotion(quantityC, quantityD);
            
            return total;
        }
    }
}
