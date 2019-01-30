#if UNITY_EDITOR
using System;
using UnityEditor;
#endif
using UnityEngine;

namespace RPGSystem
{
    public class CustomEditorGUILayout
    {
#if UNITY_EDITOR
        public static void BeginHorizontalBox(int fixedWidth, int fixedHeight, bool expandWidth, bool expandHeight)
        {
            BeginHorizontalBox(null, "", fixedWidth, fixedHeight, expandWidth, expandHeight);
        }

        public static void BeginHorizontalBox(string label, bool expandWidth, bool expandHeight)
        {
            BeginHorizontalBox(null, label, 0, 0, expandWidth, expandHeight);
        }

        public static void BeginHorizontalBox(Texture2D texture, bool expandWidth, bool expandHeight)
        {
            BeginHorizontalBox(texture, "", 0, 0, expandWidth, expandHeight);
        }

        public static void BeginHorizontalBox(Texture2D texture = null, string label = "", int fixedWidth = 0, int fixedHeight = 0, bool expandWidth = false, 
                                                bool expandHeight = false, RectOffset border = null, RectOffset margin = null, 
                                                RectOffset padding = null, RectOffset overflow = null)
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            if (border != null)
                style.border = border;
            if (margin != null)
                style.margin = margin;
            if (padding != null)
                style.padding = padding;
            if (overflow != null)
                style.overflow = overflow;
            if (fixedWidth > 0)
                style.fixedWidth = fixedWidth;
            if (fixedHeight > 0)
                style.fixedHeight = fixedHeight;
            if (texture != null)
                style.normal.background = texture;
            style.fontSize = 15;
            style.fontStyle = FontStyle.Bold;
            if (!label.Equals(""))
            {
                GUILayout.BeginHorizontal(label, style, GUILayout.ExpandWidth(expandWidth), GUILayout.ExpandHeight(expandHeight));
                GUILayout.Space(Constant.SPACE_HEADER);
            }
            else GUILayout.BeginHorizontal(style, GUILayout.ExpandWidth(expandWidth), GUILayout.ExpandHeight(expandHeight));
        }

        public static void EndHorizontalBox()
        {
            GUILayout.EndHorizontal();
        }

        public static void BeginVerticalBox(int fixedWidth, int fixedHeight, bool expandWidth, bool expandHeight)
        {
            BeginVerticalBox(null, "", fixedWidth, fixedHeight, expandWidth, expandHeight);
        }

        public static void BeginVerticalBox(string label, bool expandWidth, bool expandHeight)
        {
            BeginVerticalBox(null, label, 0, 0, expandWidth, expandHeight);
        }

        public static void BeginVerticalBox(Texture2D texture, bool expandWidth, bool expandHeight)
        {
            BeginVerticalBox(texture, "", 0, 0, expandWidth, expandHeight);
        }

        public static void BeginVerticalBox(Texture2D texture = null, string label = "", int fixedWidth = 0, int fixedHeight = 0, bool expandWidth = false,
                                                bool expandHeight = false, RectOffset border = null, RectOffset margin = null,
                                                RectOffset padding = null, RectOffset overflow = null)
        {
            GUIStyle style = new GUIStyle(GUI.skin.box);
            if (border != null)
                style.border = border;
            if (margin != null)
                style.margin = margin;
            if (padding != null)
                style.padding = padding;
            if (overflow != null)
                style.overflow = overflow;
            if (fixedWidth > 0)
                style.fixedWidth = fixedWidth;
            if (fixedHeight > 0)
                style.fixedHeight = fixedHeight;
            if (texture != null)
                style.normal.background = texture;
            style.fontSize = 15;
            style.fontStyle = FontStyle.Bold;
            
            if (!label.Equals(""))
            {
                GUILayout.BeginVertical(label, style, GUILayout.ExpandWidth(expandWidth), GUILayout.ExpandHeight(expandHeight));
                GUILayout.Space(Constant.SPACE_HEADER);
            }
            else GUILayout.BeginVertical(style, GUILayout.ExpandWidth(expandWidth), GUILayout.ExpandHeight(expandHeight));
        }

        public static void EndVerticalBox()
        {
            GUILayout.EndVertical();
        }

        public static bool Button(string label)
        {
            return GUILayout.Button(label, GUILayout.MinWidth(115), GUILayout.MinHeight(20), GUILayout.Height(20));
        }

        public static bool SquaredButton(Texture texture)
        {
            return GUILayout.Button(texture, GUILayout.MinWidth(20), GUILayout.Width(20), GUILayout.MinHeight(20),
                                        GUILayout.Height(20), GUILayout.ExpandWidth(false), GUILayout.ExpandHeight(false));
        }

        public static bool SquaredButton(string label)
        {
            return GUILayout.Button(label, GUILayout.MinWidth(20), GUILayout.Width(20), GUILayout.MinHeight(20),
                                        GUILayout.Height(20), GUILayout.ExpandWidth(false), GUILayout.ExpandHeight(false));
        }

        public static void Label(string label)
        {
            GUIStyle style = new GUIStyle(GUI.skin.label)
            {
                border = new RectOffset(0, 0, 0, 0),
                margin = new RectOffset(0, 0, 0, 0),
                padding = new RectOffset(0, 0, 0, 0),
                overflow = new RectOffset(0, 0, 0, 0),
                stretchWidth = true,
                stretchHeight = true
            };
            GUILayout.Label(label, style);
        }

        public static void BoldCenteredLabel(string label)
        {
            GUIStyle style = new GUIStyle(EditorStyles.boldLabel)
            {
                alignment = TextAnchor.MiddleCenter,
                fixedWidth = 280,
                fixedHeight = 20
            };
            GUILayout.Label(label, style);
        }

        public static string TextField(string label, string value)
        {
            value = EditorGUILayout.TextField(label, value, GUILayout.Height(20), GUILayout.ExpandWidth(true));
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static string TextArea(string label, string value)
        {
            EditorGUILayout.LabelField(label);
            GUILayout.Space(Constant.SPACE_LIGHT);
            value = EditorGUILayout.TextArea(value, GUILayout.ExpandWidth(true), GUILayout.Height(70));
            GUILayout.Space(Constant.SPACE_HIGH);
            return value;
        }

        public static int IntField(string label, int value)
        {
            value = EditorGUILayout.IntField(label, value, GUILayout.Height(20), GUILayout.ExpandWidth(true));
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static float FloatField(string label, float value)
        {
            value = EditorGUILayout.FloatField(label, value, GUILayout.Height(20), GUILayout.ExpandWidth(true));
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static Enum EnumField(string label, Enum value)
        {
            GUIStyle style = new GUIStyle(EditorStyles.popup)
            {
                stretchWidth = true,
                stretchHeight = false,
                fixedHeight = 20,
                border = new RectOffset(4, 15, 3, 3),
                margin = new RectOffset(4, 4, 3, 10),
                padding = new RectOffset(6, 14, 2, 3),
                overflow = new RectOffset(0, 0, 0, 1)
            };
            value = EditorGUILayout.EnumPopup(label, value, style);
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static Color ColorField(string label, Color value)
        {
            value = EditorGUILayout.ColorField(label, value, GUILayout.Height(20), GUILayout.ExpandWidth(true));
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static bool ToggleField(string label, bool value)
        {
            GUILayout.BeginHorizontal();
            value = EditorGUILayout.Toggle(value, GUILayout.Width(15));
            EditorGUILayout.LabelField(label, "", GUILayout.Width(55));
            GUILayout.EndHorizontal();
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static Sprite IconField(string label, Sprite icon)
        {
            GUILayout.BeginVertical(GUILayout.Width(95));
            EditorGUILayout.LabelField(label, "", GUILayout.Width(55));
            icon = (Sprite)EditorGUILayout.ObjectField(icon, typeof(Sprite), false, GUILayout.Width(82), GUILayout.Height(82));
            GUILayout.EndVertical();

            return icon;
        }

        public static Sprite[] IconField(string label, Sprite[] icon, ref int index)
        {
            GUILayout.BeginVertical(GUILayout.Width(95));
            EditorGUILayout.LabelField(label, "", GUILayout.Width(55));
            icon[index] = (Sprite)EditorGUILayout.ObjectField(icon[index], typeof(Sprite), false, GUILayout.Width(82), GUILayout.Height(82));

            GUILayout.BeginHorizontal();
            GUI.color = (index == 0) ? Constant.COLOR_GRAY : Constant.COLOR_WHITE;
            if (GUILayout.Button("1", GUILayout.Width(25), GUILayout.Height(25)))
                index = 0;
            GUI.color = (index == 1) ? Constant.COLOR_GRAY : Constant.COLOR_WHITE;
            if (GUILayout.Button("2", GUILayout.Width(25), GUILayout.Height(25)))
                index = 1;
            GUI.color = (index == 2) ? Constant.COLOR_GRAY : Constant.COLOR_WHITE;
            if (GUILayout.Button("3", GUILayout.Width(25), GUILayout.Height(25)))
                index = 2;
            GUI.color = Constant.COLOR_WHITE;
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();

            return icon;
        }

        /*public static CustomValueData CustomValueField(string label, CustomValueData value)
        {
            switch (value.Type)
            {
                case CustomValueType.Integer:
                    value.IntegerValue = IntField(label, value.IntegerValue);
                    break;

                case CustomValueType.Boolean:
                    value.BoolValue = ToggleField(label, value.BoolValue);
                    break;

                case CustomValueType.Float:
                    value.FloatValue = FloatField(label, value.FloatValue);
                    break;

                case CustomValueType.Text:
                    value.TextValue = TextField(label, value.TextValue);
                    break;

                case CustomValueType.TextArea:
                    value.TextValue = TextArea(label, value.TextValue);
                    break;

                case CustomValueType.Color:
                    value.ColorValue = ColorField(label, value.ColorValue);
                    break;

                case CustomValueType.Icon:
                    value.IconValue = IconField(label, value.IconValue);
                    break;
            }

            return value;
        }*/

        public static int Popup(string label, int selected_index, string[] displayed_options)
        {
            GUIStyle style = new GUIStyle(EditorStyles.popup)
            {
                stretchWidth = true,
                stretchHeight = false,
                fixedHeight = 20,
                border = new RectOffset(4, 15, 3, 3),
                margin = new RectOffset(4, 4, 3, 10),
                padding = new RectOffset(6, 14, 2, 3),
                overflow = new RectOffset(0, 0, 0, 1)
            };
            selected_index = EditorGUILayout.Popup(label, selected_index, displayed_options, style, GUILayout.MaxWidth(1500));
            GUILayout.Space(Constant.SPACE_LIGHT);
            return selected_index;
        }

        public static int Toolbar(int selected, string[] texts)
        {
            selected = GUILayout.Toolbar(selected, texts, GUILayout.Height(25));
            GUILayout.Space(Constant.SPACE_HIGH);
            return selected;
        }

        public static float Slider(string label, float value, float min_value, float max_value)
        {
            value = EditorGUILayout.Slider(label, value, min_value, max_value, GUILayout.Height(20), GUILayout.ExpandWidth(true));
            GUILayout.Space(Constant.SPACE_LIGHT);
            return value;
        }

        public static void ProgressBar(string label, float value, float min_value, float max_value)
        {
            Rect rect = GUILayoutUtility.GetRect(20, 20, "TextField");
            EditorGUI.ProgressBar(rect, (value - min_value) / (max_value - min_value), label);
            GUILayout.Space(Constant.SPACE_LIGHT);
        }

        /// <summary>
        /// Draws the GUI for a list of Unity.Object. Allows users to add/remove/modify a specific type
        /// deriving from Unity.Object (such as GameObject, or a Component type)
        /// </summary>
        /// <param name="header">A descriptive header</param>
        /// <param name="objects">The object list to edit</param>
        /// <param name="allowedSelectionTypes">The types of objects that are allowed to be selected</param>
        /// <typeparam name="T">The type of object in the list</typeparam>
        /*public static void DrawObjectList<T>(string header, IList<T> objects, GameObjectSelectionTypes allowedSelectionTypes) where T : UnityEngine.Object
        {
            DrawObjectList(new GUIContent(header), objects, allowedSelectionTypes);
        }*/

        /// <summary>
        /// Draws the GUI for a list of Unity.Object. Allows users to add/remove/modify a specific type
        /// deriving from Unity.Object (such as GameObject, or a Component type)
        /// </summary>
        /// <param name="header">A descriptive header</param>
        /// <param name="objects">The object list to edit</param>
        /// <param name="allowedSelectionTypes">The types of objects that are allowed to be selected</param>
        /// <typeparam name="T">The type of object in the list</typeparam>
        /*public static void DrawObjectList<T>(GUIContent header, IList<T> objects, GameObjectSelectionTypes allowedSelectionTypes) where T : UnityEngine.Object
        {
            bool allowSceneSelection = (allowedSelectionTypes & GameObjectSelectionTypes.InScene) == GameObjectSelectionTypes.InScene;
            bool allowPrefabSelection = (allowedSelectionTypes & GameObjectSelectionTypes.Prefab) == GameObjectSelectionTypes.Prefab;

            GUILayout.BeginVertical("box");
            EditorGUILayout.LabelField(header, EditorStyles.boldLabel);
            EditorGUI.indentLevel = 0;

            int toDeleteIndex = -1;
            GUILayout.BeginVertical("box");

            for (int i = 0; i < objects.Count; i++)
            {
                T obj = objects[i];
                EditorGUILayout.BeginHorizontal();

                T tempObj = (T)EditorGUILayout.ObjectField("", obj, typeof(T), allowSceneSelection);

                if (tempObj != null)
                {
                    var prefabType = PrefabUtility.GetPrefabAssetType(obj);

                    if ((prefabType == PrefabAssetType.Model && allowPrefabSelection) || (prefabType != PrefabAssetType.Model && allowSceneSelection))
                        objects[i] = tempObj;
                }

                if (GUILayout.Button("x", EditorStyles.miniButton, InspectorConstants.SmallButtonWidth))
                    toDeleteIndex = i;

                EditorGUILayout.EndHorizontal();
            }

            if (toDeleteIndex >= 0)
                objects.RemoveAt(toDeleteIndex);

            if (GUILayout.Button("Add New"))
                objects.Add(default(T));

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndVertical();
        }*/
#endif
    }
}
