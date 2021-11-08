using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutma : MonoBehaviour
{
    [SerializeField] Camera kamera;
    [SerializeField] float mesafe = 10f;
    [SerializeField] Transform objeYeri;

    Rigidbody objeRB;


    private void Update()
    {
        if (objeRB)
        {
            objeRB.MovePosition(objeYeri.transform.position);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objeRB)
            {
                objeRB.isKinematic = false;
                objeRB = null;
            }
            else
            {
                RaycastHit hit;
                Ray ray = kamera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if (Physics.Raycast(ray, out hit, mesafe))
                {
                    if (hit.transform.CompareTag("Kup"))
                    {
                        objeRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                        if (objeRB)
                        {
                            objeRB.isKinematic = true;
                        }

                    }

                }
            }
        }

    }

    
}
