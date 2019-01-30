using UnityEditor;
using UnityEngine;

namespace RPGSystem
{
    public class RarityDataCreator : MonoBehaviour
    {
        [MenuItem("Assets/Create/Rpg System/Rarity")]
        static public void CreateItem()
        {
            ScriptableObjectUtility.CreateAsset<RarityData>("NewRarity");
        }
    }
}

