using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class left : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    bool ispressed = false;
    public GameObject Player;

    void Update()
    {
        if(ispressed)
        {
            Player.transform.Translate(-0.1f,0,0);
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
