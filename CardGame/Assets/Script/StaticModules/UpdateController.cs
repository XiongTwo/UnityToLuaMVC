using UnityEngine;
using System.Collections;

namespace StaticModules
{
    public class UpdateController
    {
        private static UpdateController instance;
        private static string resURL = "http://127.0.0.1:81/";
        private GameObject View = null;

        public UpdateController()
        {
            instance = this;
        }
        public static UpdateController GetInstance()
        {
            return instance;
        }
        public GameObject Show()
        {
            if (View == null)
                View = GameObject.Instantiate(ResourceManage.GetInstance().Load("test_prefab") as GameObject);
            View.SetActive(true);
            return View;
        }
        public void Hide()
        {
            //View.SetActive(false);
            Debug.LogError(1111111111);
        }
        public IEnumerator LoadServerFiles()
        {
            WWW www = new WWW(resURL);
            yield return www;
            if (www.error != null)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.text);
            }
        }
        public ArrayList GetUpdateFileList(ArrayList server,ArrayList local)
        {
            ArrayList updateFileList = new ArrayList();
            for (int i = 0; i < server.Count; i++)
            {
                if (!local.Contains(server[i]))
                {
                    string[] splitStr = { "|" };
                    string[] tem= Common.Split(server[i].ToString(), splitStr);
                    string updateFilePath = tem[0];
                    updateFileList.Add(updateFilePath);
                }
            }
            return updateFileList;
        }
    }
}
