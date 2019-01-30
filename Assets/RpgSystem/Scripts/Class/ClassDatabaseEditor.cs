using UnityEngine;

/*namespace RPGSystem
{
    public class ClassDatabaseEditor : ScriptableObjectDatabaseEditor<ClassDatabase, ClassData>
    {
        public new void Init(ClassDatabase obj_database)
        {
            base.Init(obj_database);

            database.HaveDefaultValue = true;
            if (database.Count == 0)
            {
                ClassData item = ScriptableObject.CreateInstance<ClassData>();
                item.Name = "Default";
                database.Insert(item);
            }
        }

        /*public new void Init(string item_type)
        {
            base.Init(item_type);

            database.HaveDefaultValue = true;
            if (database.Count == 0)
            {
                ClassData item = ScriptableObject.CreateInstance<ClassData>();
                item.Name = "Default";
                database.Insert(item);
            }          
        }
    }
}*/