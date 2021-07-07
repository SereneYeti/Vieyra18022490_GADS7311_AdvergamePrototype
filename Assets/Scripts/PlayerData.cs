using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    #region Singleton Setup
    private static PlayerData instance;

    public static PlayerData Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance)
        {
            DestroyImmediate(this);
            return;

        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public int numRight;
    public float volume;
    public float brightness;
    // Start is called before the first frame update
    void Start()
    {
        volume = 0;
        brightness = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
