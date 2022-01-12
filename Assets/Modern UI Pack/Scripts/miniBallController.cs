using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniBallController : MonoBehaviour
{
    public changeColor ChangeColorScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = ChangeColorScript.arrayOfColors[Random.Range(0, 5)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
