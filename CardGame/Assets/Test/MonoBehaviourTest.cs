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
        text.text = "Error:\n";
        Object.DontDestroyOnLoad(gameObject);
    }
    void OnEnable()
    {
        Application.logMessageReceived += SSS;
    }
    void OnDisable()
    {
        Application.logMessageReceived -= SSS;
    }
    void OnDestroy()
    {
        Application.logMessageReceived -= SSS;
    }
    void SSS(string s,string ss,LogType sss)
    {
        if (sss != LogType.Error)
            return;
        text.text +=s;
        text.text += "\n";
    }
    
}
