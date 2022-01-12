using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color White;
    public Color Green;
    public Color Blue;
    public Color Red;
    public Color Purple;
    public List<Color> arrayOfColors;
    public int index;
    public Score scoreScript;
    public Lose LoseScript;
    public levelManager levelManagerScript;
    public int EasyLevelTransition;
    public int MediumLevelTransition;
    public int HardLevelTransition;
    public int ExpertLevelTransition;
    public ExtraLifePowerUp ELPScript;
    public AlwaysOnComponents AoC;

    // Start is called before the first frame update
    void Start()
    {
        arrayOfColors.Add(White);
        arrayOfColors.Add(Green);
        arrayOfColors.Add(Red);
        arrayOfColors.Add(Blue);
        arrayOfColors.Add(Purple);
        scoreScript = this.GetComponent<Score>();
        EasyLevelTransition = 0;
        MediumLevelTransition = Random.Range(9, 12);
        HardLevelTransition = Random.Range(19, 22);
        ExpertLevelTransition = Random.Range(29, 32);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Waiting(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        this.gameObject.GetComponent<SpriteRenderer>().color = arrayOfColors[index];

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Handheld.Vibrate();

        index = Random.Range(0, 5);

        if (col.gameObject.tag.Contains("block")) {
            if (col.gameObject.GetComponent<SpriteRenderer>().color.ToString() == this.gameObject.GetComponent<SpriteRenderer>().color.ToString())
            {
                Debug.Log("Scored a point");
                scoreScript.playerScore += 1;
                if (scoreScript.playerScore == EasyLevelTransition) {
                    levelManagerScript.Easy();
                        }
                else if (scoreScript.playerScore == MediumLevelTransition )
                {
                    levelManagerScript.Medium();
                        }
                else if (scoreScript.playerScore == HardLevelTransition)
                {
                    levelManagerScript.Hard();
                        }
                else if (scoreScript.playerScore == ExpertLevelTransition)
                {
                    levelManagerScript.Expert();
                        }
                this.gameObject.GetComponent<SpriteRenderer>().color = arrayOfColors[index];


            }
            else
            {
                if (this.gameObject.tag.Contains("Player"))
                {
                    if (ELPScript.lives == 0)
                    {
                        Debug.Log("lost");

                        Vector3 globalPositionOfContact = col.contacts[0].point;
                        this.gameObject.GetComponent<SpriteRenderer>().color = col.gameObject.GetComponent<SpriteRenderer>().color;
                        LoseScript.onLose(globalPositionOfContact);
                    }
                    else
                    {
                        ELPScript.lives -= 1;
                        if (ELPScript.lives == 0)
                        {
                            ELPScript.HeartImage.SetActive(false);
                            ELPScript.gameObject.SetActive(true);
                        }
                    }
                }

            }

        }
        else if (col.gameObject.name.Contains("Bottom"))
        {
            AoC.isRestarted = true;
            Vector3 globalPositionOfContact = col.contacts[0].point;
            LoseScript.onLose(globalPositionOfContact);
        }
    }

}
