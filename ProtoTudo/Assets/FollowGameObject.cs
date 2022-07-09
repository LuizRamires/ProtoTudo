using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGameObject : MonoBehaviour
{
    public GameObject toFollow;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, toFollow.transform.position, .03f);
    }
}
