﻿using UnityEngine;
using System.Collections;

public class NextPage : MonoBehaviour
{
    bool isMoving = false;
    float timer = 0;
    Vector3 start;
    Vector3 end;
    
    private InputManager im;
    private RectTransform rt;

    // Use this for initialization
    void Start ()
    {
        rt = GameObject.FindWithTag("page").GetComponent<RectTransform>();
        im = GameObject.Find("inputManager").GetComponent<InputManager>();

    }
    
    void Update (){
         if(isMoving == true)
            {
                timer += Time.deltaTime;

                rt.anchoredPosition = Vector3.Lerp(start, end, timer);

                if(timer > 1)
                {
                    isMoving = false;
                }
            }
    }
    // Update is called once per frame
   public void _ChangePageleft ()
    {
        
        isMoving = true;

        start = rt.anchoredPosition;
        end = start;
        end.x += rt.rect.width;
    
      
    }
    
     public void _ChangePageRight ()
    {

            isMoving = true;

            start = rt.anchoredPosition;
            end = start;
            end.x -= rt.rect.width;
   

      
    }
}