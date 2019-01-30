/*using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace RPGSystem
{
    public class Database : Singleton<Database>, IDrawable
    {
        public CustomValueDatabase CustomValueDatabase
        {
            get
            {
                return CustomValueDatabase.GetDatabase<CustomValueDatabase>(Constant.DB_FOLDER, Constant.DB_CUSTOM_VALUE_NAME);
            }
            private set { }
        }

        public AttributeDatabase AttributeDatabase
        {
            get
            {
                return AttributeDatabase.GetDatabase<AttributeDatabase>(Constant.DB_FOLDER, Constant.DB_ATTRIBUTE_NAME);
            }
            private set { }
        }

        public ClassDatabase ClassDatabase
        {
            get
            {
                ClassDatabase database = ClassDatabase.GetDatabase<ClassDatabase>(Constant.DB_FOLDER, Constant.DB_CLASS_NAME);
                database.Init();
                return database;
            }
            private set { }
        }

        public CategoryDatabase ItemCategoryDatabase
        {
            get
            {
                return CategoryDatabase.GetDatabase<CategoryDatabase>(Constant.DB_FOLDER, Constant.DB_ITEM_CATEGORY_NAME);
            }
            private set { }
        }

        public RarityDatabase RarityDatabase
        {
            get
            {
                return RarityDatabase.GetDatabase<RarityDatabase>(Constant.DB_FOLDER, Constant.DB_RARITY_NAME);
            }
            private set { }
        }

        public EquipSlotDatabase EquipTypeDatabase
        {
            get
            {
                return EquipSlotDatabase.GetDatabase<EquipSlotDatabase>(Constant.DB_FOLDER, Constant.DB_EQUIP_TYPE_NAME);
            }
            private set { }
        }

        public ItemDatabase ItemDatabase
        {
            get
            {
                return ItemDatabase.GetDatabase<ItemDatabase>(Constant.DB_FOLDER, Constant.DB_ITEM_NAME);
            }
            private set { }
        }

        public static Database CreateOrLoadDatabase()
        {
#if UNITY_EDITOR
            string db_full_path = @"Assets/" + Constant.DB_FOLDER + "/" + Constant.DB_MAIN_NAME;
            GameObject game_object = AssetDatabase.LoadAssetAtPath(db_full_path, typeof(GameObject)) as GameObject;
            if (game_object == null)
            {
                if (!AssetDatabase.IsValidFolder("Assets/" + Constant.DB_FOLDER))
                    AssetDatabase.CreateFolder("Assets", Constant.DB_FOLDER);

                Object prefab = PrefabUtility.CreateEmptyPrefab(db_full_path);
                GameObject go = new GameObject("Database", typeof(Database));
                PrefabUtility.ReplacePrefab(go, prefab);
                DestroyImmediate(go);
                game_object = AssetDatabase.LoadAssetAtPath(db_full_path, typeof(GameObject)) as GameObject;
            }   

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            return game_object.GetComponent<Database>();
#else
            Debug.LogFormat("Loading Database at path ({0}) with name {1}", Constant.DB_FOLDER, Constant.DB_MAIN_NAME);
            var db = Resources.Load<Database>(Constant.DB_FOLDER.Replace("Resources/", "") + "/" + Constant.DB_MAIN_NAME.Replace(".prefab", ""));
            if (db == null)
            {
                Debug.Log("No Database found");
                return null;
            }
            else
            {
                Debug.Log("Database loaded");
                return db;
            }
#endif
        }

#if UNITY_EDITOR
        public void InitEditorGUI()
        {
        }

        public void DrawEditorGUI()
        {
            CustomEditorGUILayout.BeginVerticalBox(null, "Database Settings", 0, 0, true, true, null, null, new RectOffset(20, 20, 5, 5));
            AttributeDatabase = (AttributeDatabase)EditorGUILayout.ObjectField("Attribute Database",
                                    AttributeDatabase, typeof(AttributeDatabase), false);
            GUILayout.Space(Constant.SPACE_LIGHT);

            ClassDatabase = (ClassDatabase)EditorGUILayout.ObjectField("Classes Database:", ClassDatabase, typeof(ClassDatabase), false);
            GUILayout.Space(Constant.SPACE_LIGHT);

            ItemCategoryDatabase = (CategoryDatabase)EditorGUILayout.ObjectField("Item Category Database:",
                                    ItemCategoryDatabase, typeof(CategoryDatabase), false);
            GUILayout.Space(Constant.SPACE_LIGHT);

            RarityDatabase = (RarityDatabase)EditorGUILayout.ObjectField("Rarity Database:",
                                RarityDatabase, typeof(RarityDatabase), false);
            GUILayout.Space(Constant.SPACE_LIGHT);

            EquipTypeDatabase = (EquipSlotDatabase)EditorGUILayout.ObjectField("Equip Type Database:",
                                    EquipTypeDatabase, typeof(EquipSlotDatabase), false);
            GUILayout.Space(Constant.SPACE_LIGHT);

            ItemDatabase = (ItemDatabase)EditorGUILayout.ObjectField("Item Database:",
                            ItemDatabase, typeof(ItemDatabase), false);

            EditorUtility.SetDirty(this);
            CustomEditorGUILayout.EndVerticalBox();
        }
#endif
    }
}

*/