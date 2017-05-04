using UnityEngine;
using System.Collections;
using LuaInterface;
using UnityEngine.UI;

public class Main : MonoBehaviour {

	LuaState lua=null;

    void Start () {
        Debugger.Log("Main.cs");
        Text[] text = GameObject.FindObjectsOfType<Text>();
        if (text.Length>1)
        {
            Destroy(text[1].transform.parent.parent.gameObject);
        }
        var LastLuaLooper=GameObject.FindObjectOfType<LuaLooper>();
        if (LastLuaLooper != null)
        {
            Destroy(LastLuaLooper.gameObject);
            Debugger.Log("Destroy:LastLuaLooper");
        }

        lua = new LuaState ();
		lua.Start ();
        Debugger.Log("create:LuaState");
        LuaBinder.Bind(lua);
        GameObject LuaLooper = new GameObject("LuaLooper");
        LuaLooper.AddComponent<LuaLooper>().luaState = lua;
        DontDestroyOnLoad(LuaLooper);
        Debugger.Log("create:LuaLooper");
        lua.DoFile("Main");
	}
}
