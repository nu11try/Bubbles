using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl2 : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("lvl2");
    }
}
