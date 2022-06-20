using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Quit : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {


            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("end");
            }
        }
             
    
    }
}
