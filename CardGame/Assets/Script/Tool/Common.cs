using UnityEngine;
using System.Collections;
using LuaInterface;
using StaticModules;
using System.IO;

public class Common  {

    public static string[] Split(string str,string[] s)
    {
        return str.Split(s, System.StringSplitOptions.RemoveEmptyEntries);
    }
    public static string StrTrim(string str)
    {
            return str.Trim();
    }
    public static void ReplaceFile(string _path,byte[] bytes)
    {
        string path = Application.persistentDataPath + "/" + _path;
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            string dir=System.IO.Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        File.WriteAllBytes(path,bytes);
    }
    public static string GetBuildTarget()
    {
#if UNITY_STANDALONE_WIN
        return "StandaloneWindows64";
#elif UNITY_ANDROID
        return "Android";
#elif UNITY_IOS
        return "iOS";
#endif
        return null;
    }
}
