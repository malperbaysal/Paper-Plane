using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderLerper : MonoBehaviour
{
    public Slider slider;
    
    void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            slider.value = Mathf.Lerp(slider.value, 0, Time.deltaTime*5);
        }
    }
}
