using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adsManager : MonoBehaviour
{
    public Michsky.UI.ModernUIPack.ProgressBar ProgressBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((int) ProgressBar.currentPercent == 100)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }

}
