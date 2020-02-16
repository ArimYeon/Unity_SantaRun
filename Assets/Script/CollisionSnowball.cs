using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionSnowball : MonoBehaviour {
    public float moveSpeed = 5f;
    
    private bool snowman;
   

    void Start()
    {
    }
    void Update()
    { 

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("cube"))
            Destroy(gameObject);

        if (other.gameObject.CompareTag("present"))
            Destroy(gameObject);

        if (other.gameObject.CompareTag("deer"))
            Destroy(gameObject);

        if (other.gameObject.CompareTag("tree"))
            Destroy(gameObject);
    }
}
