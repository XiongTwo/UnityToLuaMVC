using UnityEngine;
using System.Collections;
using StaticModules;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Net;
using System.IO;

public class MonoBehaviourTest : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Awake () {
        text.text = "";
        Application.logMessageReceived += SSS;
        Object.DontDestroyOnLoad(gameObject);
        //ResourceManage.GetInstance();
    }
    void SSS(string s,string ss,LogType sss)
    {
        if (sss != LogType.Error)
            return;
        text.text +=s;
        text.text += "\n";
    }
    
}
