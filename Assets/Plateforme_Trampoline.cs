using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateforme_Trampolin : MonoBehaviour
{
    public float Puisasance_Projection;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnCollisionEnter2D(Collision2D col) //col est l'information de la collision de qui avec qui et les points d'impact
    {
        if (col.gameObject.tag == "Trampoline")
        {
            //Rigidbody2D.sharMaterial = true;
        }

    }
}
