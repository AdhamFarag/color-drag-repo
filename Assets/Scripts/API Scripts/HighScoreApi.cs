using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HighScoreApi : MonoBehaviour
{

    private string HIGHSCORE_API_URL = "http://127.0.0.1:5000/HighScore";

    public void GET_CallHighScoreAPI()
    {
        StartCoroutine(GetRequest(HIGHSCORE_API_URL, LoadJsonDataCallBack));
    }

    private IEnumerator GetRequest(string url, Action<string> callback)
    {
        string response;

        UnityWebRequest www = UnityWebRequest.Get(url);
        www.downloadHandler = new DownloadHandlerBuffer();

        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            response = null;
        }
        else
        {
            response = www.downloadHandler.text;
            Debug.Log(response);
        }

        callback(response);
    }

    private void LoadJsonDataCallBack(string res)
    {
        if (res != null)
        {
            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(res);
            Debug.Log(values);
            foreach (var item in values)
            {
                Debug.Log(item.Key + " : " + item.Value);
            }
        }
    }

}
