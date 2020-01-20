using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountUp : MonoBehaviour
{
    // количество очков и их визуальное от отображение
    public int count;
    public Text score;
    //--------------------
    // Кнопки вперед и назад
    public GameObject Next;
    public GameObject Back;
    //---------------------
    public static bool dest = false;

    // количество очков за 1 элемент 
    public int countScoreOne = 10;
    //---------------------

    // элементы и тег для удаления после проигрыша
    private string bubTag = "Bub";
    private GameObject[] bubs;
    //---------------------

    // сами игровые элементы (шары, пузыри и тд)
    public GameObject[] mainGameElement;
    //---------------------

    Coroutine _spawnEl;

    void Awake()
    {
        dest = false;
    }
    void Start()
    {
        _spawnEl = StartCoroutine(Spawn());
        count = 0;        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("main");
        }
        if (BubTap.up)
        {
            UpScore();
        }
        if (Player.lose)
        {
            StopCoroutine(_spawnEl);
            bubs = GameObject.FindGameObjectsWithTag(bubTag);
            foreach (GameObject bub in bubs)
            {
                Destroy(bub);
            }
        }
    }
    IEnumerator Spawn()
    {
        float min = 0.5f;
        float max = 1.0f;

        while (!Player.lose)
        {
            if (count < 300)
            {
                min = 0.5f;
                max = 1.0f;
            }
            else if (count >= 300 && count < 600)
            {
                min = 0.4f;
                max = 0.9f;
            }
            else if (count >= 600 && count < 900)
            {
                min = 0.3f;
                max = 0.8f;

            }
            else if (count >= 900 && count < 1200)
            {
                min = 0.2f;
                max = 0.7f;
            }
            else if (count >= 1200 && count < 1500)
            {
                min = 0.1f;
                max = 0.6f;
            }
            else if (count >= 1500)
            {
                min = 0.09f;
                max = 0.5f;
            }

            foreach (var el in mainGameElement)
            {
                Instantiate(el, new Vector2(Random.Range(-2.5f, 2.5f), -4.5f), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(min, max));
            }

            yield return new WaitForFixedUpdate();
        }
    }

    void UpScore()
    {
        count += countScoreOne;
        score.text = count.ToString();
        BubTap.up = false;

        if (PlayerPrefs.GetInt("ScoreGame1") < count)
        {
            PlayerPrefs.SetInt("ScoreGame1", count);
        }
        if (count >= PlayerPrefs.GetInt(SceneManager.GetActiveScene().name))
        {
            Next.SetActive(true);
            dest = true;
        }
    }
}