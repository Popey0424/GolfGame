using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Lanceur_Vidéo : MonoBehaviour
{ //A attaché sur un objet qui n'est pas la raw Image ou le videoPlayer
    public GameObject videoPlayerObject;
    public RawImage Raw;
    public KeyCode key;

    void Start()
    {
        videoPlayerObject.SetActive(false);
        Raw.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (!videoPlayerObject.activeSelf)
            {
                Allumer();
            }
            else
            {
                Eteindre();
            }
        }
    }

    void Allumer()
    {
        print("if");
        Raw.gameObject.SetActive(true);
        videoPlayerObject.SetActive(true);
    }

    void Eteindre()
    {
        print("else");
        Raw.gameObject.SetActive(false);
        videoPlayerObject.SetActive(false);
    }
}
