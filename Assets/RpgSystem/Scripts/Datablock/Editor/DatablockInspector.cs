using UnityEditor;
using UnityEditor.Experimental;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace RPGSystem
{
    [CustomEditor(typeof(Datablock))]
    [CanEditMultipleObjects]
    public class DatablockInspector : UIElementsEditor
    {
        private SerializedProperty m_CustomValuesListProperty;
        private ReorderableList m_CustomValuesList;

        private bool m_ShowHierarchy;
        private readonly string[] m_CustomValueListNames =
        {
            "customValueInteger",
            "customValueFloat",
            "customValueBoolean",
            "customValueString",
            "customValueVector2",
            "customValueVector3",
            "customValueColor",
            "customValueSprite"
        };

        public override VisualElement CreateInspectorGUI()
        {
            var visualTree = Resources.Load("Styles/inspector_uxml") as VisualTreeAsset;
            var uxmlVE = visualTree.CloneTree(null);

            uxmlVE.AddStyleSheetPath("Inspector/inspector_styles");
            uxmlVE.AddStyleSheetPath("Basics/basics_styles");

            return uxmlVE;
        }

        protected void OnEnable()
        {
            m_CustomValuesListProperty = serializedObject.FindProperty("customValues");
            if (m_CustomValuesListProperty != null)
            {
                m_CustomValuesList = new ReorderableList(serializedObject, m_CustomValuesListProperty, true, true, true, true)
                {
                    drawHeaderCallback = (Rect rect) =>
                    {
                        EditorGUI.LabelField(rect, "Custom Values");
                    }
                };

                m_CustomValuesList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
                {
                    var element = m_CustomValuesList.serializedProperty.GetArrayElementAtIndex(index);
                    var type = element.FindPropertyRelative("type");
                    var name = element.FindPropertyRelative("m_ItemName");
                    var basicVar = element.FindPropertyRelative(m_CustomValueListNames[type.intValue]).FindPropertyRelative("m_DataContent");

                    EditorGUI.PropertyField(new Rect(rect.x, rect.y, 60, EditorGUIUtility.singleLineHeight), type, GUIContent.none);
                    EditorGUI.LabelField(new Rect(rect.x + 75, rect.y, 40, EditorGUIUtility.singleLineHeight), "Name");
                    EditorGUI.PropertyField(new Rect(rect.x + 115, rect.y, 70, EditorGUIUtility.singleLineHeight), name, GUIContent.none);
                    EditorGUI.LabelField(new Rect(rect.x + 200, rect.y, 40, EditorGUIUtility.singleLineHeight), "Value");
                    EditorGUI.PropertyField(new Rect(rect.x + 240, rect.y, rect.width - rect.x - 210, EditorGUIUtility.singleLineHeight),
                                                basicVar, GUIContent.none);
                };

                m_CustomValuesList.onRemoveCallback = (ReorderableList l) =>
                {
                    if (EditorUtility.DisplayDialog("Warning!", "Are you sure you want to delete this item?", "Yes", "No"))
                    {
                        ReorderableList.defaultBehaviours.DoRemoveButton(l);
                    }
                };
            }
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            /*DrawParent();
            EditorGUILayout.Space();
            EditorGUILayout.Space();*/

            DrawFields();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            DrawCustomValues();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            DrawOtherCustomValues();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            /*EditorGUILayout.BeginHorizontal();
            DrawNewChildButton();
            DrawCreateCopyButton();
            EditorGUILayout.EndHorizontal();

            DrawResetToParentButton();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            DrawHierarchy();*/

            serializedObject.ApplyModifiedProperties();
        }

        private void DrawParent()
        {
            Datablock datablock = (Datablock)target;
            var newParent = EditorGUILayout.ObjectField("Parent Datablock", datablock.Parent, datablock.GetType(), false) as Datablock;
            if (newParent != datablock.Parent)
            {
                if (newParent != null && newParent.GetType() != datablock.GetType())
                {
                    Debug.LogError("Parent is not the same type.");
                }
                else if (newParent != null && !datablock.IsParentValid(newParent))
                {
                    Debug.LogError("Parent would create a circular loop.");
                }
                else
                {
                    datablock.Parent = newParent;
                }
            }
        }

        private void DrawNewChildButton()
        {
            Datablock datablock = (Datablock)target;
            if (GUILayout.Button("Create new child"))
            {
                var newDatablock = CreateInstance(datablock.GetType()) as Datablock;
                newDatablock.Parent = datablock;
                string name = AssetDatabase.GenerateUniqueAssetPath(AssetDatabase.GetAssetPath(datablock));
                AssetDatabase.CreateAsset(newDatablock, name);
                Selection.activeObject = newDatablock;
                return;
            }
        }

        private void DrawCreateCopyButton()
        {
            Datablock datablock = (Datablock)target;
            if (GUILayout.Button("Create copy"))
            {
                Datablock newDatablock = CreateInstance(datablock.GetType()) as Datablock;
                newDatablock.Parent = datablock.Parent;
                string name = AssetDatabase.GenerateUniqueAssetPath(AssetDatabase.GetAssetPath(datablock));
                AssetDatabase.CreateAsset(newDatablock, name);
                Selection.activeObject = newDatablock;
                return;
            }
        }

        private void DrawResetToParentButton()
        {
            Datablock datablock = (Datablock)target;
            if (datablock.Parent != null)
            {
                EditorGUILayout.BeginHorizontal();
                if (GUILayout.Button("Reset to parent"))
                {
                    datablock.ClearParentOverrides();
                }
                EditorGUILayout.EndHorizontal();
            }
        }

        private void DrawHierarchy()
        {
            Datablock datablock = (Datablock)target;
            if (datablock.Parent != null)
            {
                m_ShowHierarchy = EditorGUILayout.Foldout(m_ShowHierarchy, "Hierarchy");
                if (m_ShowHierarchy)
                {
                    EditorGUILayout.BeginVertical();
                    Datablock parent = datablock.Parent;
                    while (parent != null)
                    {
                        if (GUILayout.Button(parent.name, EditorStyles.miniButton))
                        {
                            Selection.activeObject = parent;
                        }
                        parent = parent.Parent;
                    }
                    EditorGUILayout.EndVertical();
                }
            }
        }

        protected void DrawCustomValues()
        {
            if (m_CustomValuesListProperty != null)
            {
                m_CustomValuesList.DoLayoutList();
            }
        }

        protected virtual void DrawFields()
        {
        }

        protected virtual void DrawOtherCustomValues()
        {
        }
    }
}
