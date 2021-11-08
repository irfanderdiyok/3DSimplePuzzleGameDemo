using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Canvas;
    public bool isPaused;

    public Kamera kamera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;

        if (isPaused)
            ActiveMenu();
        else
            DeactiveMenu();
    }
    void ActiveMenu()
    {
        kamera.enabled = false;
        Time.timeScale = 0;
        AudioListener.pause = true;
        Canvas.SetActive(true);
    }
    public void DeactiveMenu()
    {
        kamera.enabled = true;
        Time.timeScale = 1;
        AudioListener.pause = false;
        Canvas.SetActive(false);
        isPaused = false;
    }
    public void AnamenuyeDon()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(0);
    }
}
