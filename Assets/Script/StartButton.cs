using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

    public GameObject panel;

	public void OnClickStart()
    {
        panel.SetActive(true);
    }

    public void OnClickLevel1()
    {
        SceneManager.LoadScene("GameScene1");
    }
    public void OnClickLevel2()
    {
        SceneManager.LoadScene("GameScene2");
    }
    public void OnClickLevel3()
    {
        SceneManager.LoadScene("GameScene3");
    }

    public void OnClickX()
    {
        panel.SetActive(false);
    }
}
