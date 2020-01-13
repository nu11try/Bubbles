using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "ButtonStart":
                SceneManager.LoadScene("lvl1");
                break;

            case "ButtonStart2":
                SceneManager.LoadScene("lvl2");
                break;
        }
    }
}