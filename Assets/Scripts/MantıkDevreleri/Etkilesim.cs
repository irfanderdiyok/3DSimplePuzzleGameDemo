using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etkilesim : MonoBehaviour
{
    public Material yesil;
    public Material kirmizi;
    public Animator anim;
    public AudioSource ses;
    bool aktiflestirebilir = false;
    public bool hangisi;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && aktiflestirebilir)
        {
            anim.Play("kapiac");
            ses.Play();
            if (hangisi)
            {
                Buffer();
            }
            else
            {
                Not();
            }


        }
    }

    void Buffer()
    {
        transform.GetChild(0).gameObject.GetComponent<Renderer>().material = yesil;
    }

    void Not()
    {
        transform.GetChild(0).gameObject.GetComponent<Renderer>().material = kirmizi;
        transform.GetChild(1).gameObject.GetComponent<Renderer>().material = yesil;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            aktiflestirebilir = true;
        }
    }
}
