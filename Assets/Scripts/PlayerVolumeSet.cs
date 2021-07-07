using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVolumeSet : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio.volume = PlayerData.Instance.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
