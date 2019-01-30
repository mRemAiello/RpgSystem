using System;
using UnityEngine;

namespace RPGSystem
{
    public class CustomValue<T>
    {
        private readonly string m_Guid;
        [SerializeField]
        private T m_DataContent;

        public Type DataType
        {
            get
            {
                return typeof(T);
            }
        }

        public Guid ID
        {
            get { return new Guid(m_Guid); }
        }

        public string Name { get; }

        public T Data
        {
            get { return m_DataContent; }
            private set { }
        }

        public CustomValue(string id, string name, T data)
        {
            m_Guid = id;
            Name = name;
            m_DataContent = data;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Content: {Data}";
        }
    }
}