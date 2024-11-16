using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public GameObject x;
    public Transform Olexa, Stepka;
    public int LightIntens;
    public float rotate;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
           
        {
            rotate -= 0.3f;
            Olexa.position += new Vector3(0.0f, 0.0f, 0.1f);
            Olexa.rotation = Quaternion.Euler(0.0f, rotate, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotate += 0.3f;
            Olexa.position -= new Vector3(0.0f, 0.0f, 0.1f);
            Olexa.rotation = Quaternion.Euler(0.0f, rotate, 0.0f);
        }
  
    }
}
