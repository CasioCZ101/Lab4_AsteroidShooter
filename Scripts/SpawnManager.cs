using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject asteroidPrefabs;
    public float rangeX = 64.0f;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //apertando a barra de espaço, spawna um asteroid
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-rangeX, rangeX), 7.0f, 70);
            Instantiate(asteroidPrefabs, spawnPos, asteroidPrefabs.transform.rotation);
        }

    }
}
