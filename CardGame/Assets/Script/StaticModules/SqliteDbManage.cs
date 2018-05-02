using UnityEngine;
using System.Collections;
using System.IO;

namespace StaticModules
{
    public class SqliteDbManage
    {
        private static SqliteDbManage instance;

        private SqliteDbHelper configDb;
        private SqliteDbHelper serverDb;
        private SqliteDbHelper cacheDb;

        public SqliteDbManage()
        {
            instance = this;
        }
        public static SqliteDbManage GetInstance()
        {
            return instance;
        }

        private SqliteDbHelper LinkDb(string _dbName)
        {
            string path = Application.persistentDataPath + "/DB/" + _dbName;
            SqliteDbHelper _db = null;
            if (File.Exists(path))
            {
                _db = new SqliteDbHelper("Data Source=" + path);
                return _db;
            }
            string url = null;
#if UNITY_EDITOR
            url = "file://" + Application.streamingAssetsPath + "/DB/" + _dbName;
#elif UNITY_ANDROID
            url = Application.streamingAssetsPath + "/DB/"+ _dbName;
#endif
            WWW www = new WWW(url);
            while (!www.isDone)
            {
                if (www.error != null)
                {
                    Debug.LogError("www.error:" + www.error);
                    return null;
                }
            }
            if (!Directory.Exists(Application.persistentDataPath))
            {
                Directory.CreateDirectory(Application.persistentDataPath);
            }
            if (!Directory.Exists(Application.persistentDataPath + "/DB"))
            {
                Directory.CreateDirectory(Application.persistentDataPath + "/DB");
            }
            File.WriteAllBytes(path, www.bytes);
            _db = new SqliteDbHelper("Data Source=" + path);
            return _db;
        }
        public SqliteDbHelper GetConfigDb()
        {
            if (configDb == null)
            {
                configDb = LinkDb("Test.db");
            }
            return configDb;
        }
        public SqliteDbHelper GetServerDb()
        {
            if (serverDb == null)
            {
                serverDb = LinkDb("Test2.db");
            }
            return serverDb;
        }
        public SqliteDbHelper GetCacheDb()
        {
            if (cacheDb == null)
            {
                cacheDb = LinkDb("Test2.db");
            }
            return cacheDb;
        }
    }
}
