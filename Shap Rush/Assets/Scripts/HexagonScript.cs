using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float expandSpeed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 0.01f;

    }
    

    //Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one * expandSpeed * Time.deltaTime;

        if (transform.localScale.x >= 0.35f)
        {
            Destroy(gameObject);
        }
        
    }

}

