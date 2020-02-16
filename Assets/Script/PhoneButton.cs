using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneButton : MonoBehaviour {
    public static bool run;
    public static bool right;
    public static bool left;
    public static bool ball;

    void start()
    {
        run = false;
        right = false;
        left = false;
        ball = false;
    }
    
    public void OnPointerDown()
    {
        run = true;
    }
    public void OnPointerUp()
    {
        run = false;
    }
    public void OnClickRight()
    {
        right = true;
    }
    public void OnClickLeft()
    {
        left = true;
    }
    public void OnClickBall()
    {
        ball = true;
    }
}
