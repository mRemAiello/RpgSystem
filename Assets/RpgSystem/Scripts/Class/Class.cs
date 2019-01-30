using System;

namespace RPGSystem
{
    public class Class
    {
        private ClassData m_Data;

        public Guid ID
        {
            get { return m_Data.ID; }
        }

        public string Name
        {
            get { return m_Data.Name; }
        }

        public string Description
        {
            get { return m_Data.description; }
        }

        public Class(ClassData classData)
        {
            m_Data = classData;
        }

        public dynamic GetCustomValue<T>(string name)
        {
            return CustomValueManager.GetCustomValue<T>(m_Data.customValues, name);
        }

        public dynamic GetCustomValue<T>(Guid id)
        {
            return CustomValueManager.GetCustomValue<T>(m_Data.customValues, id);
        }
    }
}