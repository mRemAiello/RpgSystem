/*using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace RPGSystem
{
    public class ScriptableObjectDatabaseEditor<D, T> where D : ScriptableObjectDatabase<T> where T : ScriptableObject, IEntity, ICloneable
    {
        private int selectedItemIndex = -1;
        private Vector2 scrollingPosition = Vector2.zero;
        private T tmpItem;
        Editor editor;
        private bool showDetails = false;
        private string srcString = "";
        private string errorString = "";
        private Texture UpTexture;
        private Texture DownTexture;
        private Texture2D NoBorderTexture;
        private Texture2D RightBorderTexture;

        [SerializeField]
        protected D database;

        [SerializeField]
        private string databaseName;

        [SerializeField]
        private string itemType;

        public void Init(D obj_database)
        {
            selectedItemIndex = -1;
            tmpItem = null;
            showDetails = false;

            if (UpTexture == null)
                UpTexture = Resources.Load("button_up") as Texture;
            if (DownTexture == null)
                DownTexture = Resources.Load("button_down") as Texture;
            if (NoBorderTexture == null)
                NoBorderTexture = Resources.Load("box_noborder") as Texture2D;
            if (RightBorderTexture == null)
                RightBorderTexture = Resources.Load("box_right") as Texture2D;

            if (obj_database != null)
                database = obj_database;
        }

        public string DrawEditorGUI()
        {
            CustomEditorGUILayout.BeginHorizontalBox(0, 0, true, true);
            ListView();
            DetailView();
            CustomEditorGUILayout.EndHorizontalBox();

            return errorString;
        }

        public void ListView()
        {
            CustomEditorGUILayout.BeginVerticalBox(RightBorderTexture, "", 280, 0, false, true, null, null, new RectOffset(0, 6, 3, 3));
            srcString = GUILayout.TextField(srcString);

            scrollingPosition = GUILayout.BeginScrollView(scrollingPosition, GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.Space(Constant.SPACE_HIGH);
            for (int i = 0; i < database.Count; i++)
            {
                GUI.color = (selectedItemIndex == i) ? Constant.COLOR_GRAY : Constant.COLOR_WHITE;
                if (srcString.Equals("") || database.Get(i).Name.ToLower().Contains(srcString.ToLower()))
                {
                    GUILayout.BeginHorizontal();
                    if (CustomEditorGUILayout.Button(database.Get(i).Name))
                    {
                        tmpItem = (T)database.Get(i).Clone();
                        editor = Editor.CreateEditor(tmpItem);
                        selectedItemIndex = i;
                        showDetails = true;
                        GUI.FocusControl(null);
                    }
                    GUI.color = Constant.COLOR_WHITE;

                    MoveUpButton(i);
                    MoveDownButton(i);
                    DeleteButton(i);

                    GUILayout.EndHorizontal();
                    GUILayout.Space(Constant.SPACE_LIGHT);
                }
                GUI.color = Constant.COLOR_WHITE;
            }
            GUILayout.EndScrollView();

            CustomEditorGUILayout.BeginVerticalBox(NoBorderTexture, "", 0, 0, true, false, null, new RectOffset(0, 0, 0, 5));
            CustomEditorGUILayout.BoldCenteredLabel(String.Format("Items Count: {0}", database.Count));
            CreateItemButton();
            CustomEditorGUILayout.EndVerticalBox();

            CustomEditorGUILayout.EndVerticalBox();
        }

        public void DetailView()
        {
            GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            if (tmpItem != null && showDetails)
            {
                CustomEditorGUILayout.BeginVerticalBox(NoBorderTexture, string.Format("{0} Settings", tmpItem.Name), 0, 0, true, 
                                                        true, null, new RectOffset(15, 15, 0, 5));
                editor.OnInspectorGUI();
                CustomEditorGUILayout.EndVerticalBox();
            }

            GUILayout.Space(Constant.SPACE_LIGHT);
            CustomEditorGUILayout.BeginHorizontalBox(NoBorderTexture, "", 0, 30, true, false, null, new RectOffset(15, 15, 0, 5));
            DisplayItemButtons();
            CustomEditorGUILayout.EndHorizontalBox();
            GUILayout.EndVertical();
        }

        void DisplayItemButtons()
        {
            if (showDetails)
            {
                SaveButton();
                CancelButton();
            }
        }

        void MoveUpButton(int i)
        {
            if (i == 0 && database.HaveDefaultValue)
                return;

            bool pressed = CustomEditorGUILayout.SquaredButton(UpTexture);
            if (i == 1 && database.HaveDefaultValue)
                return;
            if (pressed && i - 1 >= 0)
            {
                database.Move(i, i - 1);
                if (selectedItemIndex != -1)
                {
                    selectedItemIndex = i - 1;
                    if (selectedItemIndex < 0)
                        selectedItemIndex = 0;
                }
            }
        }

        void MoveDownButton(int i)
        {
            if (i == 0 && database.HaveDefaultValue)
                return;

            bool pressed = CustomEditorGUILayout.SquaredButton(DownTexture);
            if (pressed && i + 1 < database.Count)
            {
                database.Move(i, i + 1);
                if (selectedItemIndex != -1)
                {
                    selectedItemIndex = i + 1;
                    if (selectedItemIndex > database.Count)
                        selectedItemIndex = database.Count;
                }
            }
        }

        void DeleteButton(int i)
        {
            if (i == 0 && database.HaveDefaultValue)
                return;

            string title = string.Format("Delete {0} ?", database.Get(i).Name);
            string message = string.Format("Are you sure that you want to delete {0} from the database?", database.Get(i).Name);
            bool pressed = CustomEditorGUILayout.SquaredButton("X");
            if (pressed && EditorUtility.DisplayDialog(title, message, "Delete", "Cancel"))
            {
                database.RemoveAt(i);
                showDetails = false;
                tmpItem = null;
                selectedItemIndex = -1;
                GUI.FocusControl(null);
            }
        }

        void CreateItemButton()
        {
            GUI.color = Constant.COLOR_GREEN;
            if (CustomEditorGUILayout.Button("Create " + itemType))
            {
                tmpItem = ScriptableObject.CreateInstance<T>();
                editor = Editor.CreateEditor(tmpItem);
                showDetails = true;
                selectedItemIndex = -1;
                GUI.FocusControl(null);
            }
            GUI.color = Constant.COLOR_WHITE;
        }

        void SaveButton()
        {
            if (CustomEditorGUILayout.Button("Save"))
            {
                if (selectedItemIndex == -1)
                    database.Insert(tmpItem);
                else
                    database.Replace(selectedItemIndex, tmpItem);

                showDetails = false;
                selectedItemIndex = -1;
                tmpItem = null;
            }
        }

        void CancelButton()
        {
            if (CustomEditorGUILayout.Button("Cancel"))
            {
                showDetails = false;
                tmpItem = null;
                selectedItemIndex = -1;
            }
        }
    }
}

*/