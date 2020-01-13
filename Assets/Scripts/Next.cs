using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        switch (gameObject.name)
        {            
            case "Next":
                SceneManager.LoadScene("lvl2");
                break;
            case "Next2":
                SceneManager.LoadScene("lvl3");
                break;
            case "Next3":
                SceneManager.LoadScene("lvl4");
                break;
            case "Next4":
                SceneManager.LoadScene("lvl5");
                break;
            case "Next5":
                SceneManager.LoadScene("lvl6");
                break;
            case "Next6":
                SceneManager.LoadScene("lvl7");
                break;
            case "Next7":
                SceneManager.LoadScene("lvl8");
                break;
            case "Next8":
                SceneManager.LoadScene("lvl9");
                break;
            case "Next9":
                SceneManager.LoadScene("lvl");
                break;
        }
    }
}
