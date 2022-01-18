using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HighscoreTable : MonoBehaviour
{
    public Transform entryContainer;
    public Transform entryTemplate;
    public HighScoreApi highScoreAPI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private async void Awake()
    {
        Dictionary<string, string> returned_values;
        returned_values = await highScoreAPI.GetHighScore();

        float templateHeight = 155f;
        int i = 0;
        var sortedDict = from entry in returned_values orderby entry.Value descending select entry;

        foreach (var item in sortedDict)
        {
            if (item.Key != "None")
            {
                Transform entryTransform = Instantiate(entryTemplate, entryContainer);
                Debug.Log(item.Value);
                entryTransform.gameObject.SetActive(true);
                entryTransform.gameObject.GetComponent<TextMeshProUGUI>().text = item.Key + "  " + item.Value;
                RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
                entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
                i++;
            }
        }
    }
}
