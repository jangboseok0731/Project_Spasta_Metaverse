using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionTrigger : MonoBehaviour
{
    public GameObject InteractionInfo;
    SceneManager sceneManager;
    // Start is called before the first frame update


    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("������ �ֱ׷� ������");
            PlayerPrefs.SetString("MainScene",SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("MiniGame_FlapyBirdScene");
        }
        if (Input.GetKey(KeyCode.T))
        {
            PlayerPrefs.SetString("MainScene", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("MiniGame_TheSlackScene");
        }

    }
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
