using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubDestroy : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
