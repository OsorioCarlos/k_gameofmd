using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private float groundHorizontalLength = 20.48f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundHorizontalLength * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }
}
