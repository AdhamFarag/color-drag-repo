using System;
using UnityEngine;
public class HighScoreStructObject : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializable]
    public struct HighScoreStruct
    {
        public string Name;
        public int Score;
    }

}
