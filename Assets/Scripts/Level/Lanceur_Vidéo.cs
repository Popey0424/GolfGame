using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class Lanceur_Vidéo : MonoBehaviour
{
    // a Attaché a un objet autre que le videoPlayer sinon il pourra pas se Set.Active(True)

    public GameObject videoPlayerObject; //Objet ou il y'a le videoPlayer
    public KeyCode key;

    void Start()
    {
        videoPlayerObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            // Permet de savoir s'il est actif ou non
            if (!videoPlayerObject.activeSelf)
            {
                print("if");
                videoPlayerObject.SetActive(true);
            }
            else
            {
                print("else");
                videoPlayerObject.SetActive(false);
            }
        }
    }
}
