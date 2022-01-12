using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AlwaysOnComponents : MonoBehaviour
{
    public GameObject[] rewindTimeScript;
    public GameObject Player;
    public bool isRestarted;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (rewindTimeScript != null && rewindTimeScript.Length == 0)
        {
            rewindTimeScript = GameObject.FindGameObjectsWithTag("mini");
        }
        if (rewindTimeScript != null && rewindTimeScript.Length != 0 && Player.activeSelf)
        {
            for (int i = 0; i < rewindTimeScript.Length; i++)
            {
                rewindTimeScript[i].GetComponent<RewindTime>().isRewinding = false;

            }
            rewindTimeScript = null;
        }

    }
}
