using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuDil : MonoBehaviour
{
    public bool dil = true;
    public string[] turkce = { "Yeni oyun", "Ayarlar", "Çýkýþ" };
    public string[] ingilizce = { "New game", "Optýons", "Exit" };

    public TextMeshProUGUI Yenioyun;
    public TextMeshProUGUI Ayarlar;
    public TextMeshProUGUI Cikis;

    private void Start()
    {
        if (dil)
        {
            dilDegistir(turkce);
        }
        else
        {
            dilDegistir(ingilizce);
        }
    }

    public void dilDegistir(string[] metin)
    {
        Yenioyun.text = metin[0];
        Ayarlar.text = metin[1];
        Cikis.text = metin[2];

    }


}
