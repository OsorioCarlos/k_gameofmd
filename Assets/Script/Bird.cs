﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    private bool estaMuerto = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    public float upForce = 200f;

    private void Awake () {
        rb2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();
    }

    // Start is called before the first frame update
    private void Start () {

    }

    // Update is called once per frame
    private void Update () {
        if (estaMuerto) return;
        
        if (Input.GetMouseButtonDown (0)) {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce (Vector2.up * upForce);
            anim.SetTrigger("fly");
        }
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        estaMuerto = true;
        anim.SetTrigger("die");
    }
}