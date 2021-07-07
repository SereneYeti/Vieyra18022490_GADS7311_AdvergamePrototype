using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource audio;
    public Text volText;
    public Slider volSlider;
    // Start is called before the first frame update
    void Start()
    {
        audio = FindObjectOfType<AudioSource>();
        volText.text = "The volume is " + volSlider.value;
        volSlider.value = PlayerData.Instance.volume;
        audio.volume = PlayerData.Instance.volume;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVal()
    {
        volText.text = "The volume is " + volSlider.value*100;
        PlayerData.Instance.volume = volSlider.value;
        audio.volume = PlayerData.Instance.volume;
    }
}
