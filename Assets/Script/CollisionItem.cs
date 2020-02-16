using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionItem : MonoBehaviour {
    public static int score;
    public AudioSource audio1;
    void Start()
    {
        score = 0;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("present"))
        {
            score++;
            Destroy(other.gameObject);
            audio1.Play();
        }
    }
}
