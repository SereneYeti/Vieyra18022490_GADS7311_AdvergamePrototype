using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escape_Menu : MonoBehaviour {
    public Button[] _soundButtons;
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) UnityEngine.SceneManagement.SceneManager.LoadScene(PlayerPrefs.GetString("_LastScene"));
	}

    public void Mute()
    {
        _soundButtons[0].interactable = true;
        _soundButtons[1].interactable = false;
        PlayerPrefs.SetInt("_Mute", 1);
    }

    public void Unmute()
    {
        _soundButtons[0].interactable = false;
        _soundButtons[1].interactable = true;
        PlayerPrefs.SetInt("_Mute", 0);
    }
}
