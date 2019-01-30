using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace RPGSystem
{
    /// <summary>
    /// </summary>
    public class DatablockManager
    {
        /// <summary>
        /// Get a datablock with the specified name
        /// </summary>
        /// <param name="datablockName">Datablock name</param>
        /// <returns>Datablock</returns>
        public static Datablock GetDatablock(string datablockName)
        {
            List<Datablock> datablocks = GetAllDatablocks();
            return datablocks.FirstOrDefault(d => d.Name == datablockName);
        }

        /// <summary>
        /// Get a datablock with the specified ID
        /// </summary>
        /// <typeparam name="T">Datablock type</typeparam>
        /// <param name="id">Datablock id</param>
        /// <returns>Datablock</returns>
        public static T GetDatablock<T>(Guid id) where T : Datablock
        {
            List<Datablock> datablocks = GetAllDatablocks();
            return (T)datablocks.FirstOrDefault(d => d.ID == id);
        }

        /// <summary>
        /// Get a datablock with the specified name
        /// </summary>
        /// <typeparam name="T">Type of the datablock</typeparam>
        /// <param name="datablockName">Datablock name</param>
        /// <param name="caseInsensitive">Search case insensitive</param>
        /// <returns>Datablock</returns>
        public static T GetDatablock<T>(string datablockName, bool caseInsensitive = false) where T : Datablock
        {
            List<Datablock> datablocks = GetAllDatablocks();
            Datablock datablock;

            if (caseInsensitive)
            {
                datablock = datablocks.FirstOrDefault(db => db is T && db.name.Equals(datablockName, StringComparison.InvariantCultureIgnoreCase));
                return (T)datablock;
            }

            return null;
        }

        /// <summary>
        /// Get a datablock with the specified name
        /// </summary>
        /// <param name="datablockName">Datablock name</param>
        /// <returns>Datablock</returns>
        public static Datablock GetDatablock(string datablockName, bool caseInsensitive = false)
        {
            List<Datablock> datablocks = GetAllDatablocks();

            if (caseInsensitive)
                return datablocks.FirstOrDefault(d => d.Name.Equals(datablockName, StringComparison.InvariantCultureIgnoreCase));
            else
                return datablocks.FirstOrDefault(d => d.Name == datablockName);
        }

        /// <summary>
        /// Get a datablock with the specified name
        /// </summary>
        /// <param name="datablockName">Datablock name</param>
        /// <param name="datablockType">Type of the datablock</param>
        /// <param name="caseInsensitive">Search case insensitive</param>
        /// <returns></returns>
        public static Datablock GetDatablock(string datablockName, Type datablockType, bool caseInsensitive = false)
        {
            List<Datablock> datablocks = GetAllDatablocks();

            if (caseInsensitive)
                return datablocks.FirstOrDefault(d => d.Name.Equals(datablockName, StringComparison.InvariantCultureIgnoreCase) && d.GetType() == datablockType);
            
            return datablocks.FirstOrDefault(d => d.Name == datablockName && d.GetType() == datablockType);
        }

        /// <summary>
        /// Get all datablocks of the specified type
        /// </summary>
        /// <typeparam name="T">Datablock type</typeparam>
        /// <returns>List of all datablocks of the specified type</returns>
        public static IEnumerable<T> GetDatablocks<T>() where T : Datablock
        {
            List<Datablock> datablocks = GetAllDatablocks();
            return datablocks.Where(d => d is T).Cast<T>();
        }

        /// <summary>
        /// Get all datablocks of the specified type
        /// </summary>
        /// <param name="datablockType">Datablock type</param>
        /// <returns>List of all datablocks of the specified type</returns>
        public static IEnumerable<Datablock> GetDatablocks(Type datablockType)
        {
            List<Datablock> datablocks = GetAllDatablocks();
            return datablocks.Where(d => d.GetType() == datablockType);
        }

        /// <summary>
        /// Get a name for a datablock that is unique to that type
        /// </summary>
        /// <param name="datablockName">Desired name</param>
        /// <param name="datablockType">Datablock type</param>
        /// <returns>Unique name</returns>
        public static string GetUniqueName(string datablockName, Type datablockType)
        {
            var existing = GetDatablocks(datablockType).Any(d => d.name == datablockName);
            if (!existing)
                return datablockName;

            for (var x = 1; x < 1000; x++)
            {
                var newDatablockname = datablockName + " " + x;
                existing = GetDatablocks(datablockType).Any(d => d.name == newDatablockname);
                if (!existing)
                    return newDatablockname;
            }

            Debug.LogError("Unable to find a unique name for " + datablockName);
            return datablockName;
        }

        /// <summary>
        /// Search the project for datablocks. Generates a list of all datablocks
        /// </summary>
        public static List<Datablock> GetAllDatablocks(bool searchEntireProject = true, params string[] customSearchPaths)
        {
            List<Datablock> datablock = new List<Datablock>();
            string stringDataPath = Application.dataPath;

            if (searchEntireProject)
            {
                // Search the entire asset library for datablocks
                AddDatablocksInPath(stringDataPath, ref datablock);
            }
            else
            {
                // Search only the specified paths
                foreach (string datablockSearchPath in customSearchPaths)
                {
                    string singleFolderPath = stringDataPath.Substring(0, stringDataPath.Length - 6) + "Assets\\" + datablockSearchPath;
                    AddDatablocksInPath(singleFolderPath, ref datablock);
                }
            }

            return datablock;
        }

#if UNITY_EDITOR
        /// <summary>
        /// Add the datablocks in a path
        /// </summary>
        /// <param name="folderPath">Path</param>
        private static void AddDatablocksInPath(string folderPath, ref List<Datablock> datablockList)
        {
            string dataPath = Application.dataPath;

            var directories = new List<string>(Directory.GetDirectories(folderPath));
            foreach (string directory in directories)
            {
                AddDatablocksInPath(directory, ref datablockList);
            }

            // get the system file paths of all the files in the asset folder
            string[] allFilePaths = Directory.GetFiles(folderPath, "*.asset");

            // enumerate through the list of files loading the assets they represent and getting their type		
            foreach (string singleFilePath in allFilePaths)
            {
                string singleAssetPath = singleFilePath.Substring(dataPath.Length - 6);

                var datablock = AssetDatabase.LoadAssetAtPath(singleAssetPath, typeof(Datablock)) as Datablock;
                if (datablock == null)
                    continue;

                datablockList.Add(datablock);
            }
        }
 #endif
    }
}