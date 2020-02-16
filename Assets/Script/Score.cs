using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public GameObject D;
    Text scoreL;

    void Awake () {
        scoreL = GetComponent<Text>();
        D.SetActive(false);
	}
	
	void Update () {
        if (CollisionItem.score == 7)
        {
            scoreL.text = "You made it! Go to the Rudolf!";
            D.SetActive(true);
        }
        else
        {
            scoreL.text = "Present : " + CollisionItem.score.ToString() + " / 7";
        }

	}
}
