using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inversement : MonoBehaviour
{
   private bool isInverse = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) 
        {
            isInverse = !isInverse;

            InverserPosition();
        }
    }

    public void InverserPosition()
    {
        if (isInverse)
        {
            transform.localScale = new Vector3(1f, -1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
