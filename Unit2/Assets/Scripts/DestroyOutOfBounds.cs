using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float topBound = 60;
    private float lowerBound = -100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) {
            Destroy(gameObject); 
        } else if (transform.position.z < lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
