using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public bool start = false;
    public float duration = 1f;
    // Mettre en public un x un y un z ou faire une puissance miniamle maximal

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;// Ca creer un nv vecteur avec les vecteur de la camera
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            transform.position = startPosition + Random.insideUnitSphere; // Vecteur de la camera = au vecteur predefifini + a chaque coordonées le randomise de -1 a 1  
            //Random.insideUnitSphere etant une fct de base d'unity qui randomise de -1 a 1
            //transfor.position etant un vecteur a 3 dimension on peut pas faire transform.position.x, il faut creer un nouveau vecteur et changer une des 3 valeurs
            yield return null;
        }
        transform.position = startPosition;
    }

}
