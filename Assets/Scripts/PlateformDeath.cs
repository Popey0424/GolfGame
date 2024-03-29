using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformDeath : MonoBehaviour
{
    public Transform Spawner;
    public GameObject MainCamera;
    private Transform __all;

    private Transform ballTransform;
    public SpriteRenderer SpriteRenderer2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        __all = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Balle")
        {
            SpriteRenderer2.color = new Color(1f, 1f, 1f, 0f); // Opacit� a 0
            MainCamera.GetComponent<Shake>().start = true;
            Reset_Position();

        }
    }

    public void Reset_Position()
    {
        SpriteRenderer2.color = new Color(1f, 1f, 1f, 1f); // Opacit� a 100
        __all.transform.position = Spawner.transform.position;
    }
}
