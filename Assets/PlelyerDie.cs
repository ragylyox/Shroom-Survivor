using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlelyerDie : MonoBehaviour
{
    public Slider HP;

    public void Update()
    {
        if(HP.value <= 0)
        {
            SceneManager.LoadScene("guns");
        }
    }
}
