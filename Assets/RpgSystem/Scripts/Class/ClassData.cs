using System;
using System.Collections.Generic;
using UnityEngine;

namespace RPGSystem
{
    [Serializable]
    public class ClassData : Datablock
    {
        public string description;
        public Sprite icon;    
        public List<AttributeLink> attributes;
        public List<CustomValueAll> customValues;

        public ClassData() : base()
        {
            description = "";
            icon = default;
            customValues = new List<CustomValueAll>();
            attributes = new List<AttributeLink>();
        }
    }
}