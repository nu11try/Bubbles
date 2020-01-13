using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEarth : MonoBehaviour
{   
    [SerializeField]

    void Update()
    {
       transform.eulerAngles += new Vector3 ( 0, 0, 2 * Time.deltaTime); 
    }
}
