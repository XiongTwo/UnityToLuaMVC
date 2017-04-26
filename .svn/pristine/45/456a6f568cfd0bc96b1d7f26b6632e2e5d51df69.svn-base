using UnityEngine;
using System.Collections;
using System;
using Mono.Data.Sqlite;
using System.Data;
public class SqliteDbTest : MonoBehaviour
{

    SqliteDbHelper db;
    int id = 0;
    void Start()
    {
        Debug.LogError(Application.streamingAssetsPath);
        db = new SqliteDbHelper("Data Source="+Application.streamingAssetsPath+"/tttt.db");
        Debug.Log(db.ToString());
        /*
         SqliteDbAccess db = new SqliteDbAccess("data source=mydb1.db");
       db.CreateTable("momo",new string[]{"name","qq","email","blog"},
        new string[]{"text","text","text","text"});
       db.CloseSqlConnection();
        */
    }    public string name = "";
    public string emls = "";
    void OnGUI()
    {

        if (GUILayout.Button("create table"))
        {
            db.CreateTable("mytable", new string[] { "id", "name", "email" }, new string[] { "int", "varchar(20)", "varchar(50)" });
            Debug.Log("create table ok");
        }

        if (GUILayout.Button("insert data"))
        {

            db.InsertInto("mytable",
                         new string[] { "" + (++id), "'随风去旅行" + id + "'", "'zhangj_live" + id + "@163.com'" });

            Debug.Log("insert table ok");
        }
        if (GUILayout.Button("insert data specific"))
        {

            db.InsertIntoSpecific("mytable",
                         new string[] { "name","id" }, new string[] { "'随风去旅行6'","99" });

            Debug.Log("insert data specific ok");
        }
        if (GUILayout.Button("Delete data"))
        {

            db.Delete("mytable",
                         new string[] { "name"}, new string[] { "'随风去旅行6'"});

            Debug.Log("Delete data ok");
        }
        if (GUILayout.Button("Read Full Table"))
        {

            IDataReader sqReader=db.ReadFullTable("mytable");
            while (sqReader.Read())
            {
                string id = "id=" + sqReader.GetInt32(sqReader.GetOrdinal("id"));
                name = "name=" + sqReader.GetString(sqReader.GetOrdinal("name"));
                emls = "email=" + sqReader.GetString(sqReader.GetOrdinal("email"));
                Debug.LogError(id+"/"+name + "/" + emls);
            }

            Debug.Log("Read Full Table ok");
        }

        if (GUILayout.Button("search database"))
        {
            IDataReader sqReader = db.SelectWhere("mytable", new string[] { "name", "email" }, new string[] { "id" }, new string[] { "=" }, new string[] { "2" });
            while (sqReader.Read())
            {

                name = "name=" + sqReader.GetString(sqReader.GetOrdinal("name"));
                emls = "email=" + sqReader.GetString(sqReader.GetOrdinal("email"));
            }

        }

        if (GUILayout.Button("Update data"))
        {
            db.UpdateInto("mytable",
                         new string[] { "name", "email" }, new string[] { "'吴小雄'", "'吴小雄21a'" },
                         "id","5");

            Debug.Log("Update data ok");
        }

        if (name != "")
        {
            GUI.Label(new Rect(100, 100, 100, 100), name);
            GUI.Label(new Rect(100, 200, 100, 100), emls);
            //  GUILayout.Label(emls);
        }
        if (GUILayout.Button("close database"))
        {
            db.CloseSqlConnection();
            Debug.Log("close table ok");
        }

    }

}
