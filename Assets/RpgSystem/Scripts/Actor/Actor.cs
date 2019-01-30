using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RPGSystem
{
    public class Actor : MonoBehaviour
    {
        public ClassData classData;

        private Class m_Class;
        private List<Attribute> m_Attributes;

        public Class Class
        {
            get
            {
                if (classData == null)
                    Debug.LogError("No class defined");

                m_Class = new Class(classData);
                m_Attributes = new List<Attribute>();
                foreach (AttributeLink link in classData.attributes)
                {
                    Attribute attribute = link.attributeData.isVital ? new Vital(link.attributeData, link.defaultValue) :
                                            new Attribute(link.attributeData, link.defaultValue);
                    m_Attributes.Add(attribute);
                }

                return m_Class;
            }
            private set { }
        }

        public List<Attribute> Attributes
        {
            get
            {
                if (m_Attributes == null)
                    m_Attributes = new List<Attribute>();

                return m_Attributes;
            }
        }

        void Update()
        {
            Attributes.ForEach(x => x.Update());
        }

        public Attribute GetAttributeByName(string name)
        {
            return Attributes.FirstOrDefault(x => x.Name.Equals(name));
        }

        public Attribute GetAttributeByID(Guid id)
        {
            return Attributes.FirstOrDefault(x => x.ID == id);
        }
    }
}