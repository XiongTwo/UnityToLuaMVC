using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using System.Text;
using StaticModules;

public class BuildAB
{
    private static string path=Application.streamingAssetsPath + "/";

    [MenuItem("BuildAB/StandaloneWindows64")]
    static void BuildABToStandaloneWindows64()
    {
        if (!Directory.Exists(path + "StandaloneWindows64"))
        {
            Directory.CreateDirectory(path + "StandaloneWindows64");
        }
        BuildPipeline.BuildAssetBundles(path + "StandaloneWindows64", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        CreateFiles();
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/Android")]
    static void BuildABToAndroid()
    {
        if (!Directory.Exists(path + "Android"))
        {
            Directory.CreateDirectory(path + "Android");
        }
        BuildPipeline.BuildAssetBundles(path + "Android", BuildAssetBundleOptions.None, BuildTarget.Android);
        CreateFiles();
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/iOS")]
    static void BuildABToiOS()
    {
        if (!Directory.Exists(path + "iOS"))
        {
            Directory.CreateDirectory(path + "iOS");
        }
        BuildPipeline.BuildAssetBundles(path + "iOS", BuildAssetBundleOptions.None, BuildTarget.iOS);
        CreateFiles();
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/TargetPlatform",false,0)]
    static void BuildTargetPlatform()
    {
        if (!Directory.Exists(path + Common.targetPlatform.ToString()))
        {
            Directory.CreateDirectory(path + Common.targetPlatform.ToString());
        }
        BuildPipeline.BuildAssetBundles(path + Common.targetPlatform.ToString(), BuildAssetBundleOptions.None, (BuildTarget)System.Enum.Parse(typeof(BuildTarget), Common.targetPlatform.ToString()));
        CreateFiles();
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/CreateFiles",false,11)]
    static void CreateFiles()
    {
        string filePath = path + "Files.txt";
        if (File.Exists(filePath))
            File.Delete(filePath);
        List<string> tempList = new List<string>();
        FilePathList(path);
        for (int i = 0; i < filePathList.Count; i++)
        {
            string temp= filePathList[i].Replace(path, "")+"|"+md5file(filePathList[i]);
            string temp0=temp.Split('/')[0];
            if (temp0 == E_DevicePlatform.StandaloneWindows64.ToString() || temp0 == E_DevicePlatform.Android.ToString() || temp0 == E_DevicePlatform.iOS.ToString())
            {
                if(temp0== Common.targetPlatform.ToString())
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
        Debug.Log("Files.txt  succeed " + Common.targetPlatform);
        AssetDatabase.Refresh();
    }
    [MenuItem("BuildAB/Clear", false, 31)]
    static void Clear()
    {
        if (Directory.Exists(path + E_DevicePlatform.Android.ToString()))
        {
            Directory.Delete(path + E_DevicePlatform.Android.ToString(), true);
            Debug.LogError("Directory.Delete:"+ E_DevicePlatform.Android.ToString());
        }
        if (Directory.Exists(path + E_DevicePlatform.iOS.ToString()))
        {
            Directory.Delete(path + E_DevicePlatform.iOS.ToString(), true);
            Debug.LogError("Directory.Delete:" + E_DevicePlatform.iOS.ToString());
        }
        if (Directory.Exists(path + E_DevicePlatform.StandaloneWindows64.ToString()))
        {
            Directory.Delete(path + E_DevicePlatform.StandaloneWindows64.ToString(), true);
            Debug.LogError("Directory.Delete:" + E_DevicePlatform.StandaloneWindows64.ToString());
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
    static string[] exts = { "",".txt", ".db", ".lua", ".assetbundle" };
    static bool CanCopy(string ext)
    {   //能不能复制
        foreach (string e in exts)
        {
            if (ext.Equals(e)) return true;
        }
        return false;
    }
}
