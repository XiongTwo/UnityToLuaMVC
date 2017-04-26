using UnityEngine;
using System.Collections;
using UnityEditor;

public class SetAssetBundleName {

    [MenuItem("Assets/SetAssetBundleName")]
    static void SetAssetBundleNameEditor()
    {
        UnityEngine.Object[] selects = Selection.objects;
        foreach (UnityEngine.Object selected in selects)
        {
            string path = AssetDatabase.GetAssetPath(selected);
            AssetImporter asset = AssetImporter.GetAtPath(path);
            asset.assetBundleName = selected.name; //设置Bundle文件的名称
            asset.assetBundleVariant = "assetbundle";//设置Bundle文件的扩展名
            asset.SaveAndReimport();
        }
        AssetDatabase.Refresh();
    }
}
