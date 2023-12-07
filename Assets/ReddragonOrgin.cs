using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReddragonOrgin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    int frame_rate =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate objects with random Y positions
        float randomY = Random.Range(0.0f, 6.0f);
        if(frame_rate==0){
        Instantiate(prefab, new Vector3(transform.position.x, randomY, transform.position.z), Quaternion.identity);}
        frame_rate++;
        if(frame_rate==300){
            frame_rate=0;
        }
    }
}