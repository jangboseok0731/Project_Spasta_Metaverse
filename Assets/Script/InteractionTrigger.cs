using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public GameObject InteractionInfo;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionInfo.SetActive(true);
        }
    }
}
