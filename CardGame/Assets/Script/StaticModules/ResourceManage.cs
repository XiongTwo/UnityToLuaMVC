using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace StaticModules
{
    public class ResourceManage
    {
        private static ResourceManage instance;
        private Dictionary<string, AssetBundle> loadedAssetBundleDictionary = new Dictionary<string, AssetBundle>();
        private Dictionary<string, string> assetBundlePath = null;
        AssetBundleManifest assetBundleManifest = null;

        public ResourceManage()
        {
            Prepare();
            instance = this;
        }
        public static ResourceManage GetInstance()
        {
            return instance;
        }
        private static string persistentDataPath= Application.persistentDataPath + "/";
        private static string streamingAssetsPath = Application.streamingAssetsPath + "/";

        private void Prepare()
        {
            if (assetBundlePath == null)
            {
                assetBundlePath = new Dictionary<string, string>();
                string url = null;
                string[] filesArray=null;
                if (File.Exists(persistentDataPath + "files.txt"))
                {
                    url = persistentDataPath + "files.txt";
                    filesArray = File.ReadAllLines(url);
                }
                else
                {
#if UNITY_EDITOR
                    url = "file://"+streamingAssetsPath + "Files.txt";
#elif UNITY_ANDROID
                    url = streamingAssetsPath + "Files.txt";
#endif
                    WWW www = new WWW(url);
                    while (!www.isDone)
                    {
                        if (www.error != null)
                        {
                            Debug.LogError("www.error:" + www.error);
                            return;
                        }
                    }
                    filesArray=www.text.Split('\n');
                }
               
                for (int i = 0; i < filesArray.Length; i++)
                {
                    if (string.IsNullOrEmpty(filesArray[i]))
                        continue;
                    string[] temp = filesArray[i].Split('|');
                    string ext = Path.GetExtension(temp[0]);
                    if (ext == "" || ext == ".assetbundle")
                    {
                        string tempName = Path.GetFileNameWithoutExtension(temp[0]);
                        assetBundlePath.Add(tempName, temp[0]);
                    }
                }
            }
        }

        private void Loadependent(string _name)
        {
            string name = Path.GetFileNameWithoutExtension(_name);
            if (!loadedAssetBundleDictionary.ContainsKey(name))
            {
                string tempath = assetBundlePath[name];
                string tempath1 = persistentDataPath + tempath;
                string tempath2 = streamingAssetsPath + tempath;
                AssetBundle tempAB = null;
                if (File.Exists(tempath1))
                {
                    tempAB = AssetBundle.LoadFromFile(tempath1);
                }
                else
                {
#if !UNITY_EDITOR&&UNITY_ANDROID
                    tempath2 = Application.dataPath + "!assets/"+tempath;
#endif
                    tempAB = AssetBundle.LoadFromFile(tempath2);
                }
                if (tempAB == null)
                {
                    Debug.LogError("找不到加载文件");
                    return;
                }
                loadedAssetBundleDictionary.Add(name, tempAB);
            }
        }
        public Object Load(string name)
        {
            if (assetBundleManifest == null)
            {
                Loadependent(Common.targetPlatform.ToString());
                assetBundleManifest = loadedAssetBundleDictionary[Common.targetPlatform.ToString()].LoadAsset("AssetBundleManifest") as AssetBundleManifest;
            }
            string[] dep = assetBundleManifest.GetDirectDependencies(name + ".assetbundle");
            for (int i = 0; i < dep.Length; i++)
            {
                Loadependent(dep[i]);
            }
            Loadependent(name);
            return loadedAssetBundleDictionary[name].LoadAsset(name);
        }
    }
}
