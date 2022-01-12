using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonsUI : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] rewindTimeScript;
    public Michsky.UI.ModernUIPack.ProgressBar ProgressBar;
    public AlwaysOnComponents AoC;
    public GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {
        rewindTimeScript = GameObject.FindGameObjectsWithTag("mini");
        restartButton.GetComponent<Button>().interactable = true;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Restart()
    {
        if (AoC.isRestarted != true)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            for (int i = 0; i < rewindTimeScript.Length; i++)
            {
                rewindTimeScript[i].GetComponent<RewindTime>().startRewind();

            }
            ProgressBar.isOn = false;
            
            AoC.isRestarted = true;
            restartButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    public void OnStart()
    {
        Player.GetComponent<Rigidbody2D>().gravityScale = 1;
        this.gameObject.SetActive(false);

    }
}
