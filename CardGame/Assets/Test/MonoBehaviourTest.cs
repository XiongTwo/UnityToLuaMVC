using UnityEngine;
using System.Collections;
using StaticModules;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Net;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;

public class MonoBehaviourTest : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Awake () {
        text.text = "Error:\n";
        Application.logMessageReceived += SSS;
        Object.DontDestroyOnLoad(gameObject);
    }
    void SSS(string s,string ss,LogType sss)
    {
        if (sss != LogType.Error)
            return;
        text.text +=s;
        text.text += "\n";
    }
    
}
