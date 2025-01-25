using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Slider HP;
    public int damage;
    private void OnTriggerEnter(Collider other)
    {
        HP.value -= damage;
    }
}
