using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devre : MonoBehaviour
{
    public int Kapinin_Turu;
    public int[] girisler;
    public GameObject[] kol = new GameObject[2];
    public Material[] renkler;
    public Sprite[] spriteRenkleri;
    public Animator kapiAnim;
    public AudioSource kapiSes;
    public GameObject not;
    public bool kapininDurumu = false;


    public bool kapiyok = false;
    
    private void Start()
    {
        if (kapininDurumu)
        {
            kapiAnim.Play("kapiac");
            kapininDurumu = true;

        }
    }


    public void KolMetaryal(int renk, int hangiKol)
    {
        Renderer[] children;
        children = kol[hangiKol].gameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer rend in children)
        {
            var mats = new Material[rend.materials.Length];
            for (var j = 0; j < rend.materials.Length; j++)
            {
                mats[j] = renkler[renk];
            }
            rend.materials = mats;
        }
    }



    void GecitKapisi(bool durum)
    {
        if (durum != kapininDurumu)
        {
            if (durum)
            {
                kapiAnim.Play("kapiac");
                kapininDurumu = true;
            }
            else
            {
                kapiAnim.Play("kapikapat");
                kapininDurumu = false;
            }
            kapiSes.Play();
        }
    }

    public void Guncelleme()
    {
        if (Kapinin_Turu == 0)
        {
            VeKapisi();
        }
        else if (Kapinin_Turu == 1)
        {
            VeyaKapisi();
        }
        else if (Kapinin_Turu == 2)
        {
            OzelVeyaKapisi();
        }
        else if (Kapinin_Turu == 3)
        {
            NotVeyaKapisi();
        }
        else if (Kapinin_Turu == 4)
        {
            NotVeKapisi();
        }
        else if (Kapinin_Turu == 5)
        {
            NotOzel();
        }

    }

    void VeKapisi()
    {
        bool aktif = true;
        for (int i = 0; i < girisler.Length; i++)
        {
            if (girisler[i] == 0)
            {
                aktif = false;
                break;
            }
        }
        if (aktif)
        {
            GetComponent<Renderer>().material = renkler[1];
        }
        else
        {
            GetComponent<Renderer>().material = renkler[0];
        }
        if (!kapiyok)
        {
            GecitKapisi(aktif);
        }
        
    }

    void NotVeKapisi()
    {
        bool aktif = true;
        for (int i = 0; i < girisler.Length; i++)
        {
            if (girisler[i] == 0)
            {
                aktif = false;
                break;
            }
        }
        if (aktif)
        {
            GetComponent<Renderer>().material = renkler[1];
            not.GetComponent<Renderer>().material = renkler[0];
        }
        else
        {
            GetComponent<Renderer>().material = renkler[0];
            not.GetComponent<Renderer>().material = renkler[1];
        }
        if (!kapiyok)
        {
            GecitKapisi(!aktif);
        }
    }

    void VeyaKapisi()
    {
        bool aktif = false;
        for (int i = 0; i < girisler.Length; i++)
        {
            if (girisler[i] == 1)
            {
                aktif = true;
                break;
            }
        }
        if (aktif)
        {
            GetComponent<Renderer>().material = renkler[1];
        }
        else
        {
            GetComponent<Renderer>().material = renkler[0];
        }
        if (!kapiyok)
        {
            GecitKapisi(aktif);
        }
    }

    void NotVeyaKapisi()
    {
        bool aktif = false;
        for (int i = 0; i < girisler.Length; i++)
        {
            if (girisler[i] == 1)
            {
                aktif = true;
                break;
            }
        }
        if (aktif)
        {
            GetComponent<Renderer>().material = renkler[1];
            not.GetComponent<Renderer>().material = renkler[0];
        }
        else
        {
            GetComponent<Renderer>().material = renkler[0];
            not.GetComponent<Renderer>().material = renkler[1];
        }
        if (!kapiyok)
        {
            GecitKapisi(!aktif);
        }
    }


    void OzelVeyaKapisi()
    {
        bool aktif = true;
        for (int i = 0; i < girisler.Length; i++)
        {
            if (girisler[0] == girisler[1])
            {
                aktif = false;
                break;
            }
        }
        if (aktif)
        {
            GetComponent<SpriteRenderer>().sprite = spriteRenkleri[1];
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = spriteRenkleri[0];
        }
        if (!kapiyok)
        {
            GecitKapisi(aktif);
        }
    }


    void NotOzel()
    {
        bool aktif = true;
        for (int i = 0; i < girisler.Length; i++)
        {
            if (girisler[0] == girisler[1])
            {
                aktif = false;
                break;
            }
        }
        if (aktif)
        {
            GetComponent<SpriteRenderer>().sprite = spriteRenkleri[1];
            not.GetComponent<Renderer>().material = renkler[0];
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = spriteRenkleri[0];
            not.GetComponent<Renderer>().material = renkler[1];
        }
        if (!kapiyok)
        {
            GecitKapisi(!aktif);
        }
    }





}