using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public GameObject InteractionInfo;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("�����");
        if (other.CompareTag("Player"))
        {
            InteractionInfo.SetActive(true);
            Debug.Log("��ȣ�ۿ� ����~");
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
