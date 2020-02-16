using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoButton : MonoBehaviour {

    public GameObject panel;

    public void OnClickNo()
    {
        panel.SetActive(false);
    }
}
