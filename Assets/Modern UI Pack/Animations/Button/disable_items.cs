using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_items : MonoBehaviour
{
    public List<GameObject> objects;

    // called by Unity when the game starts
    public void enable()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(true);
        }
    }

    public void disbale()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
