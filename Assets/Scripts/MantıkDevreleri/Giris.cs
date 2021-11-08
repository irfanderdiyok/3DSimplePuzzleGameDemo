using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giris : MonoBehaviour
{
    public Devre devre;
    public int hangiKol;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kup"))
        {
            devre.KolMetaryal(1, hangiKol);
            devre.girisler[hangiKol] = 1;
            devre.Guncelleme();
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Kup"))
        {
            devre.KolMetaryal(0, hangiKol);
            devre.girisler[hangiKol] = 0;
            devre.Guncelleme();
        }
            
    }
}