using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MoveToExample()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", new Vector3(5, 5, 0), "time", 2.5f, iTween.EaseType.easeInOutSine)) ;
    
    }
}
