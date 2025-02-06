using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject player;
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
