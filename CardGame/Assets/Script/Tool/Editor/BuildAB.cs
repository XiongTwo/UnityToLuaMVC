using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using System.Text;

public class BuildAB
{
    private static string path = Application.streamingAssetsPath + "/";

    [MenuItem("BuildAB/TargetPlatform", false, 0)]
    static void BuildTargetPlatform()
    {
        BuildTarget buildTarget = GetBuildTarget();
        if (!Directory.Exists(path + buildTarget.ToString()))
        {
            Directory.CreateDirectory(path + buildTarget.ToString());
        }
        BuildPipeline.BuildAssetBundles(path + buildTarget.ToString(), BuildAssetBundleOptions.None, buildTarget);
        CreateFiles();
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/CreateFiles", false, 11)]
    static void CreateFiles()
    {
        BuildTarget buildTarget = GetBuildTarget();
        string filePath = path + "Files.txt";
        if (File.Exists(filePath))
            File.Delete(filePath);
        List<string> tempList = new List<string>();
        FilePathList(path);
        for (int i = 0; i < filePathList.Count; i++)
        {
            string temp = filePathList[i].Replace(path, "") + "|" + md5file(filePathList[i]);
            string temp0 = temp.Split('/')[0];
            if (temp0 == BuildTarget.StandaloneWindows64.ToString() || temp0 == BuildTarget.Android.ToString() || temp0 == BuildTarget.iOS.ToString())
            {
                if (temp0 == buildTarget.ToString())
                    tempList.Add(temp);
            }
            else
                tempList.Add(temp);
        }
        StreamWriter streamWriter = File.CreateText(filePath);
        for (int i = 0; i < tempList.Count; i++)
        {
            streamWriter.WriteLine(tempList[i]);
        }
        streamWriter.Close();
        Debug.Log("Files.txt  succeed " + buildTarget);
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/Clear", false, 31)]
    static void Clear()
    {
        if (Directory.Exists(path + BuildTarget.Android.ToString()))
        {
            Directory.Delete(path + BuildTarget.Android.ToString(), true);
            Debug.LogError("Directory.Delete:" + BuildTarget.Android.ToString());
        }
        if (Directory.Exists(path + BuildTarget.iOS.ToString()))
        {
            Directory.Delete(path + BuildTarget.iOS.ToString(), true);
            Debug.LogError("Directory.Delete:" + BuildTarget.iOS.ToString());
        }
        if (Directory.Exists(path + BuildTarget.StandaloneWindows64.ToString()))
        {
            Directory.Delete(path + BuildTarget.StandaloneWindows64.ToString(), true);
            Debug.LogError("Directory.Delete:" + BuildTarget.StandaloneWindows64.ToString());
        }
        if (File.Exists(path + "Files.txt"))
        {
            File.Delete(path + "Files.txt");
            Debug.LogError("File.Delete:" + "Files.txt");
        }
        AssetDatabase.Refresh();
    }
    static List<string> filePathList = new List<string>();
    static void FilePathList(string path)
    {
        string[] names = Directory.GetFiles(path);
        string[] dirs = Directory.GetDirectories(path);
        foreach (string filename in names)
        {
            string ext = Path.GetExtension(filename);
            if (!CanCopy(ext)) continue;
            string temp = filename.Replace('\\', '/');
            if (!filePathList.Contains(temp))
                filePathList.Add(temp);
        }
        foreach (string dir in dirs)
        {
            FilePathList(dir);
        }
    }
    static string md5file(string file)
    {
        try
        {
            FileStream fs = new FileStream(file, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(fs);
            fs.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
        catch (System.Exception ex)
        {
            throw new System.Exception("md5file() fail, error:" + ex.Message);
        }
    }
    static string[] exts = { "", ".txt", ".db", ".lua", ".assetbundle" };
    static bool CanCopy(string ext)
    {   //能不能复制
        foreach (string e in exts)
        {
            if (ext.Equals(e)) return true;
        }
        return false;
    }
    static BuildTarget GetBuildTarget()
    {
        BuildTarget buildTarget = BuildTarget.NoTarget;
#if UNITY_STANDALONE_WIN
        buildTarget = BuildTarget.StandaloneWindows64;
#elif UNITY_ANDROID
        buildTarget = BuildTarget.Android;
#elif UNITY_IOS
        buildTarget = BuildTarget.iOS;
#endif
        return buildTarget;
    }
}
