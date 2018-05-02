using UnityEngine;
using System.Collections;
using StaticModules;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Net;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;
using LuaInterface;

public class MonoBehaviourTest : MonoBehaviour {

    public Text text;
    ArrayList ss;
    string sss;
    
	void Awake () {
        text.text = "ErrorLog:Null\n";
        Object.DontDestroyOnLoad(gameObject);
    }
    void OnEnable()
    {
        Application.logMessageReceived += Log;
    }
    void OnDisable()
    {
        Application.logMessageReceived -= Log;
    }
    void OnDestroy()
    {
        Application.logMessageReceived -= Log;
    }
    void Log(string s,string ss,LogType sss)
    {
        if (sss != LogType.Error)
            return;
        text.text +=s;
        text.text += "\n";
    }
    
}
