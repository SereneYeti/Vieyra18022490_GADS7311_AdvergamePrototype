using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingInHandler : MonoBehaviour
{
    public GameObject toHide;
    public GameObject toShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Hide()
    {
        toHide.SetActive(false);
    }

    public void SignIn()
    {
        toShow.SetActive(true);
    }
    
}
