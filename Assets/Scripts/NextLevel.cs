using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "ButtonStart":
                SceneManager.LoadScene("lvl1");
                break;
        }
    }
}
