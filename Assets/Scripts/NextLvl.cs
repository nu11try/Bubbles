using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvl : MonoBehaviour
{

    public GameObject Score1;
    public GameObject Score2;

    public static bool next = false;
    public static bool next2 = false;
    public static bool next3 = false;
    public static bool next4 = false;
    public static bool next5 = false;

    void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "NextLvl2":
                next = true;
                Score1.SetActive(false);
                /*if (PlayerPrefs.GetInt("ScoreGame1") >= PlayerPrefs.GetInt("lvl2"))
                {
                    next = true;
                    Score1.SetActive(false);
                }
                else
                {
                    Debug.Log("Не набранно нужное количество очков");
                }*/
                break;

            case "NextLvl1":
                next2 = true;
                Score2.SetActive(false);
                break;

            case "NextLvl3":
                next3 = true;
                Score2.SetActive(false);
                /*
                if (PlayerPrefs.GetInt("ScoreGame2") >= PlayerPrefs.GetInt("lvl3"))
                {
                    next3 = true;
                    Score2.SetActive(false);
                }
                else
                {
                    Debug.Log("Не набранно нужное количество очков");
                }*/
                break;
            case "NextLvl4":
                next4 = true;                
                break;
        }
    }
}
