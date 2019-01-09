using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    #region Variables
    public Camera mainCamera;
    public Text scoreText;
    public Text gameOverText;
    public PlayerController player;

    int score;
    float gameTimer;
    bool gameOver;
    #endregion


    private void Start()
    {
        Time.timeScale = 1;

        
        player.OnHitGoomba += OnHitGoomba;
        player.OnHitSpike += OnGameOver;
        player.OnHitOrb += OnGameWin;
        
    }

    private void Update()
    {

        mainCamera.transform.position = new Vector3(
            Mathf.Lerp(mainCamera.transform.position.x, player.transform.position.x, Time.deltaTime * 10),
            Mathf.Lerp(mainCamera.transform.position.y, player.transform.position.y, Time.deltaTime * 10),
            mainCamera.transform.position.z);
        if(gameOver)
        {
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        gameTimer += Time.deltaTime;
        scoreText.text = "Time: " + Mathf.Floor(gameTimer) + "\nPress R to restart";

        if (player.transform.position.y < -10) OnGameOver();

    }

    void OnGameOver()
    {
        gameOver = true;

        scoreText.enabled = false;
        gameOverText.enabled = true;

        gameOverText.text = "Gameover!\nTime; " + Mathf.Floor(gameTimer) + "\n Pess R to restart";

        Time.timeScale = 0;
    }

    void OnGameWin()
    {
        gameOver = true;

        scoreText.enabled = false;
        gameOverText.enabled = true;

        gameOverText.text = "You Win\nTime: " + Mathf.Floor(gameTimer) + "\nPress R to restart";

        Time.timeScale = 0;
    }


    void OnHitGoomba()
    {
        score = score + 100;
    }

} // main class
