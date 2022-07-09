using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveWallComponent : MonoBehaviour
{

    public GameObject playerCamera;
    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "InteractiveWall") 
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            playerCamera.SetActive(false);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "InteractiveWall")
        {
            playerCamera.SetActive(true);
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
