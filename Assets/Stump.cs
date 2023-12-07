using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stump : MonoBehaviour
{
    // Start is called before the first frame update
   Vector3 startPosition;
    void Start()
    {
        startPosition= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(-0.03f,0,0);
       if (transform.position.x < -18){
        transform.position = startPosition;
       }
    }
}
