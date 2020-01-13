using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaultPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("lvl1", 0);
        PlayerPrefs.SetInt("lvl2", 1000);
        PlayerPrefs.SetInt("lvl3", 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
