using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] int playerscore;
    [SerializeField] TMP_Text Score;

    public void addscore(int scoreToAdd)
    {
        playerscore += scoreToAdd;
        Score.text = playerscore.ToString();
    }

    public void start_game()
    {
        SceneManager.LoadScene("lap_5");
    }

    public void restartgame()
    {
        SceneManager.LoadScene("lap_5");
    }

    public void Quitgame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Start()
    {
        
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{

        //    PauseGame();
        //}
    }

    //public void PauseGame()
    //{
    //    if (!isPaused)
    //    {
    //        Time.timeScale = 0f;
    //        isPaused = true;
    //    }
    //    else
    //    {
    //        Time.timeScale = 1f;
    //        isPaused = false;
    //    }
    //}

    public void pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }
}
