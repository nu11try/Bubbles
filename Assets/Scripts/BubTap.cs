using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BubTap : MonoBehaviour
{
    public static bool up = false;

    void Awake () {
        up = false;
    }

    void OnMouseDown () {
        Destroy (gameObject);
        up = true;
    }

    void Update () {
        if (CountUp.dest) {
            Destroy(gameObject);
        }
    }
}
