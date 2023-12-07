using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        Destroy(gameObject, 15.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.3f,0,0);

    }
  
}

