/*using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace RPGSystem
{
    public class ScriptableObjectDatabase<T> : ScriptableObject, IEnumerable where T : Datablock
    {
        [SerializeField]
        private List<T> m_Database = new List<T>();
        [SerializeField]
        public bool HaveDefaultValue = false;

        public List<T> Items
        {
            get
            {
                if (m_Database == null)
                    m_Database = new List<T>();
                return m_Database;
            }
        }

        public int Count
        {
            get { return m_Database.Count; }
        }

        public T Get(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;
            return Items.FirstOrDefault(x => x.Name.Equals(name));
        }

        public T Get(int id)
        {
            for (int i = 0; i < Count; i++)
            {
                if (m_Database[i].ID == id)
                    return m_Database[i];
            }
            return default;
        }

        public T GetByIndex(int index)
        {
            if (Count > 0)
            {
                if (index >= 0 && index < Count)
                    return m_Database[index];
                return default;
            }
            return default;
        }

        /*public bool Exists(int index)
        {
            if (index < 0 || index >= m_Database.Count)
                return false;

            return true;
        }

        public bool Exists(int id)
        {
            return m_Database.Exists(x => x.ID == id);
        }

        public bool Exists(T item)
        {
            return m_Database.Exists(x => x == item);
        }

        public int IndexOf(T item)
        {
            return m_Database.IndexOf(item);
        }

        public void Sort()
        {
            m_Database.Sort((x, y) => string.Compare(x.Name, y.Name));
        }

        public IEnumerator GetEnumerator()
        {
            return m_Database.GetEnumerator();
        }

#if UNITY_EDITOR
        public static U GetDatabase<U>(string db_folder, string db_name) where U : ScriptableObject
        {
            string db_full_path = @"Assets/" + db_folder + "/" + db_name;
            U database = AssetDatabase.LoadAssetAtPath(db_full_path, typeof(U)) as U;
            if (database == null)
            {
                if (!AssetDatabase.IsValidFolder("Assets/" + db_folder))
                    AssetDatabase.CreateFolder("Assets", db_folder);

                database = CreateInstance<U>();
                AssetDatabase.CreateAsset(database, db_full_path);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            return database;
        }

        public void InsertAt(int index, T item)
        {
            string db_full_path = AssetDatabase.GetAssetPath(GetInstanceID());
            m_Database.Insert(index, item);
            item.name = item.Name;
            EditorUtility.SetDirty(this);
            EditorUtility.SetDirty(item);
            AssetDatabase.AddObjectToAsset(item, db_full_path);
            AssetDatabase.ImportAsset(db_full_path);
            AssetDatabase.SaveAssets();
        }

        public void Insert(T item)
        {
            InsertAt(Count, item);
        }

        public void RemoveAt(int index)
        {
            T item = Items[index];
            DestroyImmediate(item, true);
            m_Database.RemoveAt(index);
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssets();
        }

        public void Remove(T item)
        {
            RemoveAt(IndexOf(item));
        }

        public void Replace(int index, T item)
        {
            item.CopyTo(m_Database[index]);
            EditorUtility.SetDirty(this);
        }

        public void Move(int old_index, int new_index)
        {
            T item = m_Database[old_index];
            m_Database[old_index] = m_Database[new_index];
            m_Database[new_index] = item;
            EditorUtility.SetDirty(this);
        }
#endif
    }
}*/