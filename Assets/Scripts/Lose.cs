using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public GameObject minis;
    public GameObject LoseMenu;
    public GameObject Blocks;
    public GameObject[] rewindTimeScript;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        rewindTimeScript = GameObject.FindGameObjectsWithTag("mini");
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    public void onLose(Vector3 pos) {
        LoseMenu.SetActive(true);
        Blocks.GetComponent<Drag>().enabled = false;
        minis.transform.position = pos;

        this.gameObject.SetActive(false);

        minis.gameObject.SetActive(true);
    }
    public void onReset()
    {
        LoseMenu.SetActive(false);
        Blocks.GetComponent<Drag>().enabled = true;

        this.gameObject.SetActive(true);
        restartButton.GetComponent<Button>().interactable = true;

        minis.gameObject.SetActive(false);
    }


}
