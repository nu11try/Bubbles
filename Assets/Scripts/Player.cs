using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Rest;
    public GameObject Back;
    public static bool lose = false;

    void Awake () {
        lose = false;
    }

    void OnTriggerEnter2D (Collider2D other) {        

        if (other.gameObject.tag == "Bub"){                                   
            lose = true;
            Rest.SetActive (true);
            Back.SetActive (true);
        }
    }
}
