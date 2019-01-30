using UnityEngine;

namespace RPGSystem
{
    public class RarityData : Datablock
    {
        public Color color;       
        public Sprite icon;

        public RarityData() : base()
        {
            color = Color.black;
            icon = default;
        }
    }
}