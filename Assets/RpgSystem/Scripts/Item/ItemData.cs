/*using System;
using UnityEngine;

namespace RPGSystem
{
    [Serializable]
    public class ItemData : EntityShortName, ICloneable
    {
        [SerializeField]
        public string Description;        
        [SerializeField]
        public RarityData Rarity;
        [SerializeField]
        public CategoryData Category;
        [SerializeField]
        public uint Level;
        [SerializeField]
        public Sprite Icon;
        [SerializeField]
        private Vector2 itemSize;
        [SerializeField]
        public bool IsBuyable, IsSellable, IsDestructible;
        [SerializeField]
        public int BuyPrice, SellPrice, MaxDurability;

        //private List<Modifier> modifiers;

        public uint RowSize
        {
            get { return (uint)itemSize.x; }
            set { itemSize.x = value; }
        }

        public uint ColSize
        {
            get { return (uint)itemSize.y; }
            set { itemSize.y = value; }
        }

        public ItemData()
        {
            id = Guid.NewGuid();
            itemName = "Need Name";
            ShortName = "";
            Description = "";

            IsBuyable = false;
            IsSellable = false;
            IsDestructible = false;

            BuyPrice = 0;
            SellPrice = 0;
            MaxDurability = 0;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public new void CopyTo(IEntity entity)
        {
        }
    }
}*/