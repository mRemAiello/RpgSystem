using UnityEditor;

namespace RPGSystem
{
    public class AttributeDataCreator
    {
        [MenuItem("Assets/Create/Rpg System/Attribute")]
        static public void CreateItem()
        {
            ScriptableObjectUtility.CreateAsset<AttributeData>("NewAttribute");
        }
    }
}

