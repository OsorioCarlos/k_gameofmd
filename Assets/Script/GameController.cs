using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject gameOverText;
    public bool gameOver;

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