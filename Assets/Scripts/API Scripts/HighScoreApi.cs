using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
public class HighScoreApi : MonoBehaviour
{

    private string HIGHSCORE_API_URL = "http://127.0.0.1:5000/HighScore";

    public Dictionary<string, string> returned_values;
    public async Task<Dictionary<string, string>> GetHighScore()
    {
        using var www = UnityWebRequest.Get(HIGHSCORE_API_URL);
        var operation = www.SendWebRequest();
        while (!operation.isDone)
        {
            await Task.Yield();
        }
        var jsonResponse = www.downloadHandler.text;

        if (www.result == UnityWebRequest.Result.Success)
        {
            Debug.Log(www.downloadHandler.text);
        }
        else
        {
            Debug.Log("failed" + www.error);
        }

        try
        {
            var result = JsonConvert.DeserializeObject<Dictionary<string,string>>(jsonResponse);
            return result;

        }catch(Exception ex)
        {
            Debug.Log("OPERATION FAILED" + ex.Message);
        }
        return null;
    }
}
