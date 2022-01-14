using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterChooser : MonoBehaviour
{
    public string CharacterName;
    public characterChosen characterChosenScript;
    // Start is called before the first frame update
    void Start()
    {
        characterChosenScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<characterChosen>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetNameOfChosen()
    {
        Sprite ThisImage = this.gameObject.GetComponent<Image>().sprite;
        CharacterName = this.gameObject.GetComponent<Button>().name;
        characterChosenScript.ChangeCharacter(ThisImage);

    }
}
