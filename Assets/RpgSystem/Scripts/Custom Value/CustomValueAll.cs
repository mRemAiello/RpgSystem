using System;
using UnityEngine;

namespace RPGSystem
{
    [Serializable]
    public class CustomValueAll
    {
        [SerializeField]
        private string m_ItemName;

        [SerializeField]
        private string m_Guid;

        public CustomValueEnumType type;

        public CustomValueInteger customValueInteger;
        public CustomValueFloat customValueFloat;
        public CustomValueBoolean customValueBoolean;
        public CustomValueString customValueString;
        public CustomValueVector2 customValueVector2;
        public CustomValueVector3 customValueVector3;
        public CustomValueColor customValueColor;
        public CustomValueSprite customValueSprite;

        /// <summary>
        /// A stable, unique identifier for the datablock.
        /// </summary>
        public Guid ID
        {
            get { return new Guid(m_Guid); }
        }

        /// <summary>
        /// Custom value name
        /// </summary>
        public string Name
        {
            get { return m_ItemName; }
            set { m_ItemName = value; }
        }

        public CustomValueAll()
        {
            m_ItemName = "";
            m_Guid = Guid.NewGuid().ToString();
        }
    }
}