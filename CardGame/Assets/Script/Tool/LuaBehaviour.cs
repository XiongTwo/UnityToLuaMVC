using UnityEngine;
using System.Collections;
using LuaInterface;
using StaticModules;


public class LuaBehaviour : MonoBehaviour {

    
    public static void AddLuaBehaviourLiftCycleFunction(E_MonoBehaviourLiftCycle _LiftCycle, LuaFunction _LuaFunction)
    {
        switch (_LiftCycle)
        {
            case E_MonoBehaviourLiftCycle.Awake:
                AwakeFun = _LuaFunction;
                break;
            case E_MonoBehaviourLiftCycle.Start:
                StartFun = _LuaFunction;
                break;
            case E_MonoBehaviourLiftCycle.Update:
                UpdateFun = _LuaFunction;
                break;
            case E_MonoBehaviourLiftCycle.OnEnable:
                OnEnableFun = _LuaFunction;
                break;
            case E_MonoBehaviourLiftCycle.OnDisable:
                OnDisableFun = _LuaFunction;
                break;
        }
    }
    public static void AddLuaBehaviour(GameObject go)
    {
        go.AddComponent<LuaBehaviour>();
    }
    public static LuaFunction AwakeFun;
    public static LuaFunction StartFun;
    public static LuaFunction UpdateFun;
    public static LuaFunction OnEnableFun;
    public static LuaFunction OnDisableFun;

    void Awake(){
        if(AwakeFun!=null)
            AwakeFun.Call(gameObject);
    }
    void OnEnable()
    {
        if (OnEnableFun != null)
            OnEnableFun.Call(gameObject);
    }
    void OnDisable()
    {
        if (OnDisableFun != null)
            OnDisableFun.Call(gameObject);
    }
    void Start () {
        if (StartFun != null)
            StartFun.Call(gameObject);
    }
	
	void Update () {
        if (UpdateFun != null)
            UpdateFun.Call(gameObject);
    }
}
