using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterChosen : MonoBehaviour
{
    public string chosenCharacter;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeCharacter(Sprite CharacterImage)
    {
        Player.GetComponent<SpriteRenderer>().sprite = CharacterImage;
    }
}
