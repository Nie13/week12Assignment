using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTreeBehavior : MonoBehaviour
{
    public GameObject tree;
    public GameObject trunk;

    // Start is called before the first frame update
    void Start()
    {
        tree.SetActive(true);
        trunk.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            if(tree.activeInHierarchy)
            {
                tree.SetActive(false);
                trunk.SetActive(true);
            }
        }
    }
}
