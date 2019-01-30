/*using System;
using UnityEngine;
using System.Collections.Generic;

namespace RPGSystem
{
    [Serializable]
    public class CategoryData : Entity, ICloneable
    {
        [SerializeField]
        private List<string> subcategories;

        public CategoryData()
        {
            id = Guid.NewGuid();
            subcategories = new List<string>();
        }

        public object Clone()
        {
            CategoryData data = CreateInstance<CategoryData>();
            data.ID = (SerializableGuid)ID.Clone();
            data.Name = Name;
            data.subcategories = new List<string>();
            for (int i = 0; i < subcategories.Count; i++)
                data.subcategories.Add(subcategories[i]);
            return data;
        }

        public override void CopyTo(IEntity entity)
        {
            CategoryData data = (CategoryData)entity;
            data.ID.Value = ID.Value;
            data.Name = Name;
            data.subcategories = new List<string>();
            for (int i = 0; i < subcategories.Count; i++)
                data.subcategories.Add(subcategories[i]);
        }
    }
}*/