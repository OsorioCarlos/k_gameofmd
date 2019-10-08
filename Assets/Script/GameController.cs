using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public GameObject gameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;

    private int score;
    public Text scoreText;

    public void Awake()
    {
        if (GameController.instance == null)
        {
            GameController.instance = this;
        } else if (GameController.instance != this)
        {
            Destroy(gameObject);

        }
    }
    
    public void BirdScored(){
        if (gameOver) return;
        score++;
        scoreText.text = "Puntaje: " + score;
    }

    // Update is called once per frame
    public void Update () {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void BirdDie () {
        gameOverText.SetActive (true);
        gameOver = true;
    }
}