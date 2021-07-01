using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UI_Controller : MonoBehaviour
{
    public Image boost;
    public Image slow;
    public GameObject [] health;
    public GameObject pauseMenuUI;
    //public Image[] health;
    public bool[] heartEnabled = { false, false, false };
    public PlayerMovement player;
    public int tempHealth = 0;
    public static bool gameIsPaused = false;
    public PickupController pickupController;
    public bool keyPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        pickupController = FindObjectOfType<PickupController>();
        boost.enabled = false;
        slow.enabled = false;
        game_Manager.Instance.playerHealth = 0;
        for(int x = 0; x < 3; x++)
        {
            heartEnabled[x] = false;
            health[x].SetActive(heartEnabled[x]);
           // health[x].enabled = false;
        }
    }
   

    void Pause()
    {
        //Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Debug.Log("Pause");
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public bool hasLife()
    { bool temp;
        if (heartEnabled[0])
        {
            temp = true;
            heartEnabled[0] = false;
            health[0].SetActive(heartEnabled[0]);
        }
        else
        {
            temp = false;
        }
            return temp;
    }
    public void Resume()
    {
        //Cursor.visible = false;
        Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void LoadMenu()
    {
        Debug.Log("Load");
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void TakeHit()
    {
        heartEnabled[tempHealth] = false;
        health[tempHealth].SetActive(!health[tempHealth].activeSelf);
        //Debug.Log(health[tempHealth].activeSelf);
        //Debug.Log(tempHealth);
        //Debug.Log("HIT");
        tempHealth--;
    }

    public void Health()
    {
        try
        {
            if (game_Manager.Instance.soulBar.Soul.value == game_Manager.Instance.soulBar.MAX_SOUL)
            {
                if (tempHealth < 4)
                {
                    tempHealth++;
                    //Debug.Log(tempHealth);
                    game_Manager.Instance.playerHealth = tempHealth;
                    // health[tempHealth--].SetActive(true);
                    health[tempHealth].SetActive(!health[tempHealth].activeSelf);
                    heartEnabled[tempHealth] = true;

                    //health[tempHealth--].enabled = true;
                    game_Manager.Instance.NewHealthBar();
                }
                game_Manager.Instance.soulBar.SetValue(0);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
        }
       
    }
    public void pickupVisiblility()
    {
        if(player.boost)
        {
            boost.enabled = true;            
        }
        else
        {
            boost.enabled = false;
        }

        if (player.slow)
        {
            slow.enabled = true;
        }
        else
        {
            slow.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        pickupVisiblility();
        Health();
        if (Input.GetKeyDown(KeyCode.P))
        {
            keyPressed = true;
            gameIsPaused = !gameIsPaused;
        }
        if(keyPressed)
        {
            if (gameIsPaused)
            {
                keyPressed = false;
                Pause();
            }
            else
            {
                keyPressed = false;
                Resume();
            }
        }
        
    }
}
