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

            total += ApplyPromotionAorB(quantityA, priceA, promoQuantityA, promoPriceA);

            total += ApplyPromotionAorB(quantityB, priceB, promoQuantityB, promoPriceB);

            total += ApplyCDPromotion(quantityC, quantityD, priceC, priceD, promoPriceCD);
            
            return total;
        }

        private int ApplyPromotionAorB(int quantity, int price, int promoQuantity, int promoPrice)
        {
            var promoUnits = quantity / promoQuantity;
            var normalUnits = quantity % promoQuantity;
            return (promoUnits * promoPrice) + (normalUnits * price);
        }

        private int ApplyCDPromotion(int quantityC, int quantityD, int priceC, int priceD, int promoPriceCD)
        {
            return (quantityC * priceC) + (quantityD * priceD);
        }
    }
}
