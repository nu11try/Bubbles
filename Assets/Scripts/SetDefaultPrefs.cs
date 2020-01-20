using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaultPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("lvl1", 1000);
        PlayerPrefs.SetInt("lvl2", 2000);
        PlayerPrefs.SetInt("lvl3", 3000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
