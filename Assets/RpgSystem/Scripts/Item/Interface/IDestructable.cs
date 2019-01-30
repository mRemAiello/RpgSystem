namespace RPGSystem
{
    public interface IDestructible
    {
        bool IsDestructible
        {
            get;
            set;
        }

        int Durability
        {
            get;
            set;
        }

        int MaxDurability
        {
            get;
            set;
        }
    }
}

