using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Overlay : MonoBehaviour
{
    public Slider slider;
    public Image image; 

    private void Start()
    {
        
    }

    public void AdjustBrigthness(float x)
    {
        var tempColor = image.color;
        tempColor.a = 1 - x; 
        image.color = tempColor;
        PlayerPrefs.SetFloat("brigthness", x);
        PlayerPrefs.Save();
    }
}
