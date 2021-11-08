using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Ayarlar : MonoBehaviour
{
    public MenuDil MenuDil;
    public GameObject manager;

    public void DilDegistir(int deger)
    {
        if (deger == 0)
        {
            MenuDil.dil = true;
            MenuDil.dilDegistir(MenuDil.turkce);
        }else if(deger == 1)
        {
            MenuDil.dil = false;
            MenuDil.dilDegistir(MenuDil.ingilizce);
        }
    }

    public void GrafikKalitesi(int deger)
    {
        QualitySettings.SetQualityLevel(deger);
    }


    public void SesKapat(int deger)
    {
        if (deger == 1)
        {
            AudioListener.pause = true;
        }
        else if (deger == 0)
        {
            AudioListener.pause = false;
        }
    }










    public void Telif(int deger)
    {
        if (deger == 1)
        {
            manager.GetComponent<AudioSource>().enabled = false;
        }
        else if (deger == 0)
        {
            manager.GetComponent<AudioSource>().enabled = true;
        }

    }





}
