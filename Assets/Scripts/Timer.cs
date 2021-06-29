using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public double gameTimer = 10.0f;

    private void Start()
    {
        timer = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        timer.text = "Remaining Time :\n" + System.Math.Round(gameTimer, 1);
        if(gameTimer == 0.00)
        {
            
        }
    }
}
