using UnityEditor;
using UnityEngine;

namespace RPGSystem
{
    [CustomEditor(typeof(AttributeData))]
    [CanEditMultipleObjects]
    public class AttributeInspector : DatablockInspector
    {
        SerializedProperty m_NameProperty;
        SerializedProperty m_InternalNameProperty;
        SerializedProperty m_Icon;
        SerializedProperty m_DescriptionProperty;
        SerializedProperty m_MaxValueProperty;
        SerializedProperty m_MinValueProperty;
        SerializedProperty m_ClampTypeProperty;
        SerializedProperty m_IsVitalProperty;

        protected new void OnEnable()
        {
            base.OnEnable();

            m_NameProperty = serializedObject.FindProperty("m_ItemName");
            m_InternalNameProperty = serializedObject.FindProperty("internalName");
            m_Icon = serializedObject.FindProperty("icon");
            m_DescriptionProperty = serializedObject.FindProperty("description");
            m_MinValueProperty = serializedObject.FindProperty("minValue");
            m_MaxValueProperty = serializedObject.FindProperty("maxValue");
            m_IsVitalProperty = serializedObject.FindProperty("isVital");
            m_ClampTypeProperty = serializedObject.FindProperty("clampType");
        }

        protected override void DrawFields()
        {
            EditorGUILayout.PropertyField(m_NameProperty, new GUIContent("Name"));
            EditorGUILayout.PropertyField(m_InternalNameProperty, new GUIContent("Internal Name"));
            EditorGUILayout.PropertyField(m_Icon, new GUIContent("Icon"), true);
            EditorGUILayout.PropertyField(m_DescriptionProperty, new GUIContent("Description"), GUILayout.ExpandWidth(true), GUILayout.Height(70));
            EditorGUILayout.PropertyField(m_MinValueProperty, new GUIContent("Min Value"));
            EditorGUILayout.PropertyField(m_MaxValueProperty, new GUIContent("Max Value"));
            EditorGUILayout.PropertyField(m_ClampTypeProperty, new GUIContent("Clamp Type"));
            EditorGUILayout.PropertyField(m_IsVitalProperty, new GUIContent("Is Vital"));
        }
    }
}