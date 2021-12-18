namespace LastTesst.Helper
{
    public static class Price
    {
        public static int totalPriceWith = 0;
        public static int totalPriceWithout = 0;

        public static void addPriceWith(int price)
        {
            totalPriceWith += price;
        }
        
        public static void addPriceWithout(int price)
        {
            totalPriceWith += price;
        }
        
        public static void makeZero()
        {
            totalPriceWith = 0;
            totalPriceWithout = 0;
        }
    }
}