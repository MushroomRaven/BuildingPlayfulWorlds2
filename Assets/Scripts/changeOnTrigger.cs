using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeOnTrigger : MonoBehaviour
{
    // public GameObject buildings;
    public GameObject PP;
    public Material skyOne;
    public GameObject blob ;
    public GameObject VFX;
    public GameObject musicBox ; 
    public cameraShake cameraShake;
    public AudioSource sociopath; 

    [SerializeField] private Animator Particles;
    [SerializeField] private string bubbles;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")

        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //buildings.SetActive(true);
                PP.SetActive(true);
                blob.SetActive(true);
                VFX.SetActive(false);
                musicBox.SetActive(false); 
                RenderSettings.skybox = skyOne;
                Particles.SetBool("on", true);
                StartCoroutine(cameraShake.Shake(.15f, .4f));
         
                sociopath.Play(); 
            }
            


        }
    }


}
