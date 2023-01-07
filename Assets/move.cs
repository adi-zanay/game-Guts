using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;
  
[RequireComponent (typeof(Rigidbody))]  
  
public class move : MonoBehaviour {  
  
    public float xForce = 500f;  
    public float zForce = 500f;  
    public float yForce = 500.0f;  
  
    //use this for initialization  
  
    void Start () {  
          
    }  
    //Update is called once per frame  
    void Update () {  
        //this is for x axis' movement  
  
        float x = 0.0f;  
        if (Input.GetKey (KeyCode.LeftArrow)) {  
            x = x - xForce;  
        }  
  
        if (Input.GetKey (KeyCode.RightArrow)) {  
            x = x + xForce;  
        }  
  
        //this is for z axis' movement  
  
        float z = 0.0f;  
        if (Input.GetKey (KeyCode.DownArrow)) {  
            z = z - zForce;  
        }  
  
        if (Input.GetKey (KeyCode.UpArrow)) {  
            z = z + zForce;  
        }  
        //this is for z axis' movement  
  
        float y= 0.0f;  
        if (Input.GetKeyDown (KeyCode.Space)) {  
            y = yForce;  
        }  
  
        GetComponent<Rigidbody>().AddForce (x, y, z);  
    }  
    private void OnTriggerEnter(Collider other)
    {
        /* if(other.gameObject.CompareTag("Coin"))
         Destroy(other.gameObject);
         Scorescript.scorevalue +=10;*/
    
        if(other.gameObject.CompareTag("enemy"))
        Destroy(other.gameObject);
        SceneManager.LoadScene("GameOver");
    }
}  