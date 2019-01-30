namespace RPGSystem
{
    public interface IBuyable
    {
        bool IsBuyable
        {
            get;
            set;
        }

        int BuyPrice
        {
            get;
            set;
        }
    }
}
