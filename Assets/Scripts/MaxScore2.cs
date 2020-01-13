using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore2 : MonoBehaviour
{
    void Start()
    {
        GetComponent <Text> ().text = PlayerPrefs.GetInt ("ScoreGame2").ToString ();
    }
}
