using UnityEngine;
using System.Collections;

namespace StaticModules
{
    public class UpdateController
    {
        private static UpdateController instance;
        private static string resURL = "http://127.0.0.1:81/";
        private GameObject View = null;

        public static UpdateController GetInstance()
        {
            if (instance == null)
                instance = new UpdateController();
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
            View.SetActive(false);
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
    }
}
