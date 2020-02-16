using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDeer : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (CollisionItem.score == 7)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
