using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shroom : MonoBehaviour
{
   
    public GameObject Text;

    public void OnTriggerStay(Collider other)
    {
        //Text.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            //inventoryscript.shroomcounter++;
            //Debug.Log(inventoryscript.shroomcounter);
            Destroy(gameObject);
            

        }
    }


    public void OnTriggerExit(Collider other)
    {
    }
}
