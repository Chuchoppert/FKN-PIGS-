using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseMenuUI;

    //Pigs
    public GameObject Pigs;

    //UI
    public static TextMeshProUGUI GuardCounterText;
    public static TextMeshProUGUI KeyCounterText;

    public static int KeyScore;
    public static int GuardScore;

    // Start is called before the first frame update
    void Start()
    {
        KeyCounterText = GameObject.FindGameObjectWithTag("KeyText").GetComponent<TextMeshProUGUI>();
        GuardCounterText = GameObject.FindGameObjectWithTag("GuardText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if(Pigs.transform.childCount == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }


    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
