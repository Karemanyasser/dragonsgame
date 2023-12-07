using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BluedragonMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        input();
        
    }
    void input(){
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0.02f,0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,-0.02f,0);
        }
         if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefab, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
        }
       
    }
    
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Stump" || other.gameObject.tag == "reddragon"){
            Destroy(gameObject);
            SceneManager.LoadScene("Start"); 
            Score.scoreValue=0;

        }
    }
}
