using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public GameObject InteractionInfo;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("여기냐");
        if (other.CompareTag("Player"))
        {
            InteractionInfo.SetActive(true);
            Debug.Log("상호작용 가능~");
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionInfo.SetActive(false);
        }
    }
}
