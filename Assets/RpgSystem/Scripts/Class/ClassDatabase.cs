/*namespace RPGSystem
{
    public class ClassDatabase : ScriptableObjectDatabase<ClassData>
    {
#if UNITY_EDITOR
        public void Init()
        {
            if (database.Count == 0)
            {
                ClassData item = CreateInstance<ClassData>();
                item.Name = "Default";
                Insert(item);
            }
        }
#endif
    }
}*/