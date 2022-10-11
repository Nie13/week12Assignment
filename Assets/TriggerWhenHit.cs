using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWhenHit : MonoBehaviour
{
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        targetObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            if (targetObject.activeInHierarchy)
            {
                targetObject.SetActive(false);
            }
        }
    }

}
