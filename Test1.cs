using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public Transform transformCub;
    public Transform transformSphera;
    public float x;
    public float y;
    public int speed;
    private void Update()
    {

        y += speed * Time.deltaTime;
        x += speed * Time.deltaTime;
        transformCub.position = new Vector3(x, y, 25f);
    }
}
