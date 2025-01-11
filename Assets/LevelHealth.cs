using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelHealth : MonoBehaviour
{

    public int levelHealth = 100;
    public Slider mySlider;
    public Image myImage;
    public Camera maincamera;

    void Update()
    {
        mySlider.value = levelHealth;
        if (levelHealth < 10)
        {
            myImage.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (levelHealth > 50)
        {
            maincamera.fieldOfView = 135;

        }
        else
        {
            myImage.enabled = true;
        }
    }
       
}



