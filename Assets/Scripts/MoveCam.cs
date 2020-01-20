using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveCam : MonoBehaviour
{
    public GameObject Score1;
    public GameObject Score2;
    [SerializeField]
    private float moveSpeed = 0.2f;

    public AudioSource[] BackMusics;
    public GameObject[] StartBtb;

    public Sprite[] SpritePlay;
    public Sprite[] SpriteCase;

    void Update()
    {        
        if (NextLvl.next)
        {
            BackMusics[0].volume -= 0.0052f;
            if (PlayerPrefs.GetInt("ScoreGame1") >= PlayerPrefs.GetInt(SceneManager.GetActiveScene().name))
            {
                StartBtb[0].GetComponent<SpriteRenderer>().sprite = SpritePlay[0];
                StartBtb[0].name = "ButtonStart2";
            }
            else StartBtb[0].GetComponent<SpriteRenderer>().sprite = SpriteCase[0];
            if (transform.position.x >= 16.1f && transform.position.x <= 16.3f)
            {
                BackMusics[0].volume = 0f;
                BackMusics[0].Stop();
                BackMusics[1].volume = 1f;
                BackMusics[1].Play();           
                
                NextLvl.next = false;
                Score2.SetActive(true);                       
            }
            else
            {
                transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            }
        }
        else if (NextLvl.next2)
        {
            BackMusics[1].volume -= 0.0052f;
            if (transform.position.x <= 0.05f)
            {
                BackMusics[1].volume = 0f;
                BackMusics[1].Stop();
                BackMusics[0].volume = 1f;
                BackMusics[0].Play();

                NextLvl.next2 = false;
                Score1.SetActive(true);                              
            }
            else
            {
                transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            }
        }
        else if (NextLvl.next3)
        {
            if (transform.position.x >= 38.4f && transform.position.x <= 38.7f)
            {
                NextLvl.next3 = false;
            }
            else
            {
                transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            }
        }
        else if (NextLvl.next4)
        {
            if (transform.position.x >= 58.68f && transform.position.x <= 58.9f)
            {
                NextLvl.next4 = false;
            }
            else
            {
                transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            }
        }
        else if (NextLvl.next5)
        {
            if (transform.position.x >= 77.55f && transform.position.x <= 77.75f)
            {
                NextLvl.next5 = false;
            }
            else
            {
                transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            }
        }
    }
}
