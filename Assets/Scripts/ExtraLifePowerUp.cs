using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLifePowerUp : MonoBehaviour
{
    public int lives = 0;
    public GameObject HeartImage;
    // Start is called before the first frame update
    void Start()
    {
        changePosition();
    }
    void changePosition()
    {
        this.gameObject.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-3.0f, 3.0f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Contains("Player"))
        {
            lives += 1;
            HeartImage.SetActive(true);
            changePosition();
            this.gameObject.SetActive(false);
        }
    }

}
