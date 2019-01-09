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

        /*
        player.OnHitGoomba += OnHitGoomba;
        player.OnHitSpike += OnGameOver;
        player.OnHitOrb += OnGameWin;
        */
    }


} // main class
