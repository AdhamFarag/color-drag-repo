using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindTime : MonoBehaviour
{
    public bool isRewinding = false;
    List<Vector2> positions;
    public GameObject Player;
    public Lose LoseScript;
    public AlwaysOnComponents AOC;
    // Start is called before the first frame update
    void Start()
    {
        positions = new List<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.GetKeyDown(KeyCode.Return))
        {
            startRewind();
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            stopRewind();
        }*/
    }
    private void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else {
            if (this.gameObject.activeSelf && AOC.isRestarted==false)
            {
                Record();
            }
            else
            {
                stopRewind();
            }

        }
    }
    void Record()
    {
        positions.Insert(0, transform.position);
    }
    void stopRecord()
    {

    }
    void Rewind()
    {
        if (positions.Count > 0)
        {
           
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else
        {
            stopRewind();
            positions.Clear();
            isRewinding = false;

            LoseScript.onReset();
        }
    }
    public void startRewind()
    {
        isRewinding = true;
    }
    public void stopRewind()
    {
        isRewinding = false;
    }
}
