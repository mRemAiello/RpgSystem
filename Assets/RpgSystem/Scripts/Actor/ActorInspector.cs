using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

/*namespace RPGSystem
{
    [CustomEditor(typeof(Actor))]
    public class ActorInspector : Editor
    {
        int tmpItem;
        string[] displayedOptions;
        ClassDatabase classDatabase;

        void OnEnable()
        {
            classDatabase = Database.CreateOrLoadDatabase().ClassDatabase;
            displayedOptions = classDatabase.Items.Select(x => x.NameAndShortName).ToArray();

            var serializedObject = new SerializedObject(target);
            for (int i = 0; i < classDatabase.Count; i++)
            {
                if (classDatabase.Items[i] == serializedObject.FindProperty("classData").GetValue<ClassData>())
                {
                    tmpItem = i;
                    break;
                }
            }
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.BeginVertical();
            {
                displayedOptions = classDatabase.Items.Select(x => x.NameAndShortName).ToArray();
                tmpItem = CustomEditorGUILayout.Popup("Select Class:", tmpItem, displayedOptions);

                var serializedObject = new SerializedObject(target);
                ClassData classData = Database.CreateOrLoadDatabase().ClassDatabase.Get(tmpItem);
                serializedObject.FindProperty("classData").SetValue(classData);
                EditorGUILayout.Space();

                EditorGUILayout.BeginVertical();
                {
                    EditorGUILayout.LabelField(string.Format("{0} Attributes", classData.NameAndShortName), EditorStyles.boldLabel);
                    foreach (AttributeLink link in classData.Attributes)
                    {
                        link.AttributeBaseValue = CustomEditorGUILayout.Slider(link.Attribute.NameAndShortName, link.AttributeBaseValue,
                                                            link.Attribute.MinValue, link.Attribute.MaxValue);

                        CustomEditorGUILayout.ProgressBar(link.Attribute.NameAndShortName, link.AttributeBaseValue,
                                                            link.Attribute.MinValue, link.Attribute.MaxValue);
                    }
                }
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndVertical();

            if (GUI.changed)
            {
                GUI.changed = false;
                EditorUtility.SetDirty(target);
                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            }
        }
    }
}
*/
