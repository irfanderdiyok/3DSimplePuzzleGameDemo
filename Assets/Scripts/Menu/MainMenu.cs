using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI Gamename;
    public GameObject menu;
    public GameObject ayarlar;

    private void Start()
    {
        Gamename.text = "455343415045\n46524f4d\n5a45524f";
        StartCoroutine(NameChanger());
    }

    IEnumerator NameChanger()
    {
        yield return new WaitForSeconds(0.8f);
        Gamename.text = "E5343415045\n46524fM\nZ45524f";
        yield return new WaitForSeconds(0.7f);
        Gamename.text = "E53434150E\nF524fM\nZ45524f";
        yield return new WaitForSeconds(0.6f);
        Gamename.text = "E53C4150E\nF524fM\nZ4552O";
        yield return new WaitForSeconds(0.9f);
        Gamename.text = "ESC4150E\nFR4fM\nZ45RO";
        yield return new WaitForSeconds(0.6f);
        Gamename.text = "ESC41PE\nFROM\nZ45RO";
        yield return new WaitForSeconds(0.8f);
        Gamename.text = "ESCAPE\nFROM\nZERO";
    }

    public void Back()
    {
        ayarlar.SetActive(false);
        menu.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        menu.SetActive(false);
        ayarlar.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }




}
