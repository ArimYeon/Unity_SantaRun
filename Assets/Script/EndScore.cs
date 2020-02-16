using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

    Text scoreL;
    void Awake()
    {
        scoreL = GetComponent<Text>();
    }

    void Update () {
        scoreL.text = "Oh no...\nYou collected \'" + CollisionItem.score.ToString() + "\' presents\nThere was \'"+(7-CollisionItem.score).ToString()+"\' presents more\nTry again!";
    }
}
