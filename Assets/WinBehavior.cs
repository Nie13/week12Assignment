using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject originalText;
    public GameObject winText;

    void Start()
    {
        originalText.SetActive(true);
        winText.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword") ){
            if(originalText.activeInHierarchy)
            {
                originalText.SetActive(false);
                winText.SetActive(true);
            }
        }
    }
}
