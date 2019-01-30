/*using UnityEditor;
using UnityEngine;

namespace RPGSystem
{
    public class MainWindowEditor : EditorWindow
    {
        private bool tabChanged;
        private int selectedItemIndex;
        private string[] categories = { "Databases", "Custom Values", "Attributes", "Classes", "Item Rarities", "Item Categories",
                                        "Equip Slots", "Items" };

        private Database database;
        private CustomValueDatabaseEditor customValueDatabaseEditor = new CustomValueDatabaseEditor();
        private AttributeDatabaseEditor attributeDatabaseEditor = new AttributeDatabaseEditor();
        private ClassDatabaseEditor classDatabaseEditor = new ClassDatabaseEditor();
        private CategoryDatabaseEditor itemCategoryDatabaseEditor = new CategoryDatabaseEditor();
        private RarityDatabaseEditor rarityDatabaseEditor = new RarityDatabaseEditor();
        private EquipTypeDatabaseEditor equipTypeDatabaseEditor = new EquipTypeDatabaseEditor();
        private ItemDatabaseEditor itemDatabaseEditor = new ItemDatabaseEditor();

        [MenuItem("Rpg System/Open Database")]
        public static void Init()
        {
            MainWindowEditor window = (MainWindowEditor)GetWindow(typeof(MainWindowEditor));
            window.minSize = new Vector2(Constant.MAIN_WINDOW_WIDTH, Constant.MAIN_WINDOW_HEIGHT);
            window.titleContent = new GUIContent("Database Editor");
            window.Show();
        }

        private void OnEnable()
        {
            selectedItemIndex = -1;
            tabChanged = false;

            ReloadDatabases();
        }

        private void ReloadDatabases()
        {
            database = Database.CreateOrLoadDatabase();

            customValueDatabaseEditor.Init(database.CustomValueDatabase);
            attributeDatabaseEditor.Init(database.AttributeDatabase);
            classDatabaseEditor.Init(database.ClassDatabase);
            itemCategoryDatabaseEditor.Init(database.ItemCategoryDatabase);
            rarityDatabaseEditor.Init(database.RarityDatabase);
            equipTypeDatabaseEditor.Init(database.EquipTypeDatabase);
            itemDatabaseEditor.Init(database.ItemDatabase);
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            CustomEditorGUILayout.BeginVerticalBox(null, "", 230, 0, false, true, null, null, new RectOffset(10, 10, 10, 10));
            for (int i = 0; i < categories.Length; i++)
            {
                GUI.color = (selectedItemIndex == i) ? Constant.COLOR_GRAY : Constant.COLOR_WHITE;
                if (CustomEditorGUILayout.Button(categories[i]))
                {
                    tabChanged = true;
                    selectedItemIndex = i;
                }
                GUI.color = Constant.COLOR_WHITE;
                GUILayout.Space(Constant.SPACE_VERY_LIGHT);
            }
            CustomEditorGUILayout.EndVerticalBox();

            if (tabChanged)
            {
                ReloadDatabases();
                tabChanged = false;
            }

            switch (selectedItemIndex)
            {
                case 0:
                    database.DrawEditorGUI();
                    break;

                case 1:
                    customValueDatabaseEditor.DrawEditorGUI();
                    break;

                case 2:
                    attributeDatabaseEditor.DrawEditorGUI();
                    break;

                case 3:
                    classDatabaseEditor.DrawEditorGUI();
                    break;

                case 4:
                    itemCategoryDatabaseEditor.DrawEditorGUI();
                    break;

                case 5:
                    rarityDatabaseEditor.DrawEditorGUI();
                    break;

                case 6:
                    equipTypeDatabaseEditor.DrawEditorGUI();
                    break;

                case 7:
                    itemDatabaseEditor.DrawEditorGUI();
                    break;
            }
            GUILayout.EndHorizontal();

            CustomEditorGUILayout.BeginHorizontalBox(0, 30, true, false);
            CustomEditorGUILayout.Label("BOH PROVA LOLLLONE");
            CustomEditorGUILayout.EndHorizontalBox();
        }
    }
}
*/