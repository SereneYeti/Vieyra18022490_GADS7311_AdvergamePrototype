using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject settings;   
    bool sVis;
    // Start is called before the first frame update
    void Start()
    {
        sVis = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSettingtsVis()
    {
        Debug.Log("Settings");
        sVis = !sVis;
        settings.SetActive(sVis);   
        
    }

}
