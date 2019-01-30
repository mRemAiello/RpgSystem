using UnityEditor;

namespace RPGSystem
{
    public class ClassDataCreator
    {
        [MenuItem("Assets/Create/Rpg System/Class")]
        static public void CreateItem()
        {
            ScriptableObjectUtility.CreateAsset<ClassData>("NewClass");
        }
    }
}
