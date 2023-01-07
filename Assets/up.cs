using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class up : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    bool ispressed = false;
    public GameObject Player;

    void Update()
    {
        if(ispressed)
        {
            Player.transform.Translate(0,0,0.1f);
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
}
