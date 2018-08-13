using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject gameOverText;
    public GameObject gameWinText;
    //public GameObject DeathPanel;
    public static bool gameOver = false;
    public static bool gameWin = false;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Update() {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameOver = false;
        }
        if (gameOver == true && Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("LevelScreen", LoadSceneMode.Single);
            gameOver = false;
        }
        if (gameWin == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("LevelScreen", LoadSceneMode.Single);
            gameWin = false;
        }
    }
    public void FixedUpdate()
    {
        if (gameWin == true)
        {
            gameWinText.SetActive(true);
        }
    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
    public void BirdWin() {
        gameWinText.SetActive(true);
        gameWin = true;
    }
    public void ChangeToScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }
    public void exitApp()
    {
            Application.Quit();
            Debug.Log("Game is exiting");
    }
}
