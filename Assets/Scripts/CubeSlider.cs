using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSlider : MonoBehaviour
{
    public Slider slider;
    [Range(0,1)]
    public float speed = 0.5f;
    
    void Update()
    {
        //transform.position = transform.position + Vector3.forward;
        //transform.position += Vector3.forward;
        //transform.position += Vector3.forward * speed;
        
        if (Input.GetKey(KeyCode.W))//W basıldığında ileri git
        {
            transform.position += Vector3.forward * speed;
        }

        if (Input.GetKey(KeyCode.S))//S basıldığında geri git
        {
            transform.position += Vector3.back * speed;
        }
        
        //transform.localRotation*=Quaternion.Euler(0,slider.value* 360 * -Time.deltaTime* 1.1f,0);
    }
}
