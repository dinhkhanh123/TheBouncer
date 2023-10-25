using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public TMP_Text valueText;
    int progress = 100;
    public Slider slider;
    
   public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }

    public void UpdateProgress()
    {
        progress--;
        slider.value = progress;
    }
}
