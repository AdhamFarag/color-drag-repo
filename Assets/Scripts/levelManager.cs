using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] Blocks;
    // Start is called before the first frame update
    void Start()
    {
        Blocks = GameObject.FindGameObjectsWithTag("block");


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Easy()
    {
        player.GetComponent<Rigidbody2D>().mass = 1;
        player.GetComponent<ball>().maxSpeed = 2;

    }
    public void Medium()
    {
        player.GetComponent<Rigidbody2D>().mass = 1f;
        player.GetComponent<ball>().maxSpeed = 3;
        for (int i = 0; i < Blocks.Length; i += 2)
        {
            Blocks[i].GetComponent<Animator>().Play("in and out");
        }


    }
    public void Hard()
    {
        player.GetComponent<Rigidbody2D>().mass = 1f;
        player.GetComponent<ball>().maxSpeed = 4;
        for (int i = 1; i < Blocks.Length; i += 2)
        {
            Blocks[i].GetComponent<Animator>().Play("in and out");
        }
    }
    public void Expert()
    {
        player.GetComponent<Rigidbody2D>().mass = .8f;
        player.GetComponent<ball>().maxSpeed = 5;


    }
}
