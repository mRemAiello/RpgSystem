/*using System;

namespace RPGSystem
{
    [Serializable]
    public class EquipSlotData : Entity, ICloneable
    {
        public EquipSlotData()
        {
            id = Guid.NewGuid();
        }

        public object Clone()
        {
            EquipSlotData data = CreateInstance<EquipSlotData>();
            data.ID = (SerializableGuid)ID.Clone();
            data.Name = Name;
            return data;
        }

        public override void CopyTo(IEntity entity)
        {
            EquipSlotData data = (EquipSlotData)entity;
            data.ID.Value = ID.Value;
            data.Name = Name;
        }
    }
}
*/