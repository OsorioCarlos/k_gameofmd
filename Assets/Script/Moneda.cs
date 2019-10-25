using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public GameObject coin;

    private void OnTriggerEnter2D(Collider2D collider) {
        GameController.instance.BirdScored();
        coin.SetActive(false);
    }

}
