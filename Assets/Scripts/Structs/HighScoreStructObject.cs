using System;
using UnityEngine;
using System.Collections.Generic;
public class HighScoreStructObject : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializable]
    public struct HighScoreStruct
    {
        public Dictionary<string, string> Users { get; set; }
    }

}
