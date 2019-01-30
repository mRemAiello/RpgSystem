using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace RPGSystem
{
    [CustomEditor(typeof(ClassData))]
    [CanEditMultipleObjects]
    public class ClassDataInspector : DatablockInspector
    {
        SerializedProperty m_NameProperty;
        SerializedProperty m_InternalNameProperty;
        SerializedProperty m_IconProperty;
        SerializedProperty m_AttributesListProperty;
        SerializedProperty m_DescriptionProperty;

        ReorderableList m_AttributesList;

        protected new void OnEnable()
        {
            base.OnEnable();

            m_NameProperty = serializedObject.FindProperty("m_ItemName");
            m_InternalNameProperty = serializedObject.FindProperty("internalName");
            m_IconProperty = serializedObject.FindProperty("icon");
            m_AttributesListProperty = serializedObject.FindProperty("attributes");
            m_DescriptionProperty = serializedObject.FindProperty("description");

            m_AttributesList = new ReorderableList(serializedObject, m_AttributesListProperty, true, true, true, true)
            {
                drawHeaderCallback = (Rect rect) =>
                {
                    EditorGUI.LabelField(rect, "Attributes");
                }
            };
            m_AttributesList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
            {
                var element = m_AttributesList.serializedProperty.GetArrayElementAtIndex(index);
                var attributeData = element.FindPropertyRelative("attributeData");
                var defaultValue = element.FindPropertyRelative("defaultValue");

                EditorGUI.PropertyField(new Rect(rect.x, rect.y, 170, EditorGUIUtility.singleLineHeight), attributeData, GUIContent.none);
                EditorGUI.LabelField(new Rect(rect.x + 180, rect.y, 40, EditorGUIUtility.singleLineHeight), "Value");
                EditorGUI.PropertyField(new Rect(rect.x + 220, rect.y, rect.width - 220, EditorGUIUtility.singleLineHeight), defaultValue, GUIContent.none);
            };
        }

        protected override void DrawFields()
        {
            EditorGUILayout.PropertyField(m_NameProperty, new GUIContent("Name"));
            EditorGUILayout.PropertyField(m_InternalNameProperty, new GUIContent("Internal Name"));
            EditorGUILayout.PropertyField(m_DescriptionProperty, new GUIContent("Description"), GUILayout.ExpandWidth(true), GUILayout.Height(70));
            EditorGUILayout.PropertyField(m_IconProperty, new GUIContent("Icon"));
        }

        protected override void DrawOtherCustomValues()
        {
            m_AttributesList.DoLayoutList();
        }
    }
}
