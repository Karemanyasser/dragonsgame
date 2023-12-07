using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reddragonmove : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        Destroy(gameObject, 25.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.04f,0,0); 

    }

    private void FallDown(){  // Enable gravity for falling effect
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        if (rigidbody != null)
        {
            rigidbody.gravityScale = 2.0f;
            if(transform.position.y <= -7){
            Destroy(gameObject);}
        }}

    private void ChangeColor(){ // Change the color to black
    
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Color.black; 
        }
    }

    

    private void OnCollisionEnter2D(Collision2D other){
    if(other.gameObject.tag == "fireball"){ // when collision with bluedragon or fireball it falls and turn to black 
        FallDown();
        ChangeColor();
        Destroy(other.gameObject);
        Score.scoreValue+=1; 
     }
     if(other.gameObject.tag == "bluedragon" || other.gameObject.tag == "Stump"){
       Destroy(gameObject);
     }}

}

