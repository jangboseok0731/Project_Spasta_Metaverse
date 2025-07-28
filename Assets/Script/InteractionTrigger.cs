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
            Debug.Log("에헤이 왜그래 나한테");
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
