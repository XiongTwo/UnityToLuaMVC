using UnityEngine;
using System.Collections;
using LuaInterface;
using StaticModules;

public class Common  {

//#if UNITY_EDITOR
//    public static E_DevicePlatform targetPlatform = E_DevicePlatform.StandaloneWindows64;
#if UNITY_STANDALONE_WIN
    public static E_DevicePlatform targetPlatform = E_DevicePlatform.StandaloneWindows64;
#elif UNITY_ANDROID
    public static E_DevicePlatform targetPlatform = E_DevicePlatform.Android;
#elif UNITY_IPHONE
    public static E_DevicePlatform targetPlatform = E_DevicePlatform.iOS;
#endif

}
