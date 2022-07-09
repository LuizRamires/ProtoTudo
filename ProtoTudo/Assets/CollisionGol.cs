using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGol : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject ballCamera;
    public GameObject teamMates;
    public AudioSource audioSource;
    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Bola")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Gol do vampeta");
            mainCamera.SetActive(false);
            ballCamera.SetActive(true);
            teamMates.SetActive(true);
            audioSource.Play();
        }
    }
}
