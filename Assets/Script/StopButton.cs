using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopButton : MonoBehaviour {

    public GameObject panel;

    public void OnClickHome()
    {
        panel.SetActive(true);
    }

    public void OnClickYes()
    {
        SceneManager.LoadScene("StartScene");
    }
}
