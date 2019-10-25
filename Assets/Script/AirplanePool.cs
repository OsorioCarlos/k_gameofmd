using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplanePool : MonoBehaviour
{
    public int airplanePoolSize = 5;
    public GameObject airplanePrefab;

    public float AirplaneMin = -4f;
    public float AirplaneMax = 1.5f;
    private float spawnXPosition = 11f;

    private GameObject[] airplanes;
    private Vector2 objectPoolPosition = new Vector2(-14, 0);

    private float timeSinceLastSpawned;
    public float spawnRate;

    private int currentAriplane;

    // Start is called before the first frame update
    private void Start()
    {
        airplanes = new GameObject[airplanePoolSize];
        for(int i=0; i<airplanePoolSize; i++){
            airplanes[i] = Instantiate(airplanePrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (!GameController.instance.gameOver && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(AirplaneMin, AirplaneMax);
            airplanes[currentAriplane].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentAriplane ++;

            if (currentAriplane >= airplanePoolSize)
            {
                currentAriplane = 0;
            }

        }

    }
}
