using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class down : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    bool ispressed = false;
    public GameObject Player;

    void Update()
    {
        if(ispressed)
        {
            Player.transform.Translate(0,0,-0.1f);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
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
