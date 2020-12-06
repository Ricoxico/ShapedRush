using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject[] shapesPrefabs;
    private float nextTimeToSpawn = 0f;
    Vector2 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = new Vector2(0.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>= nextTimeToSpawn)
        {
            int ShapeToSpawn = Random.Range(0, 4);
                Instantiate(shapesPrefabs[ShapeToSpawn], newPosition, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            
        }
        
    }
}
