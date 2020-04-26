using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class updateSlider : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    public string name;
    float temp;
    void Awake()
    {
        audioMixer.GetFloat(name, out temp);
        slider.value = temp;
    }
}
