using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSLider : MonoBehaviour
{
    public Text brightText;
    public Slider brightSlider;
    // Start is called before the first frame update
    void Start()
    {
        brightText.text = "The brightness is " + brightSlider.value;
        brightSlider.value = PlayerData.Instance.volume;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeVal()
    {
        brightText.text = "The volume is " + brightSlider.value * 100;
        PlayerData.Instance.volume = brightSlider.value;
    }
}
