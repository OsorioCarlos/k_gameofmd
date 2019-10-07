using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public GameObject gameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;

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
    // Start is called before the first frame update
    public void Start () {

    }

    // Update is called once per frame
    public void Update () {

    }

    public void BirdDie () {
        gameOverText.SetActive (true);
        gameOver = true;
    }
}