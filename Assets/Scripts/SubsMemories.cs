using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class SubsMemories : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public bool subDec = false;
    [TextArea]
    public string text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            textBox.text = text;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            textBox.text = ""; 
        }
    }
}

