using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject[] shapesPrefabs;
    

    private float nextTimeToSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>= nextTimeToSpawn)
        {
            int ShapeToSpawn = Random.Range(0, 3);
                Instantiate(shapesPrefabs[ShapeToSpawn], Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            
        }
        
    }
}
