using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class makeItButton : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;

    void Start()
    {
        button = this.gameObject; 
    }

     void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            unityEvent.Invoke(); 
        
        
        
        }
    }
















}
