using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowButton : MonoBehaviour {

    public void OnClickStart()
    {
        SceneManager.LoadScene("HowScene");
    }
}
