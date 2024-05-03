using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 
using System.Collections; 

public class LevelChanger : MonoBehaviour
{
    public string levelToLoad = "Level1";
    public TextMeshProUGUI messageText; 
    public float delayBeforeLoading = 2.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(DisplayMessageAndLoadLevel());
        }
    }

    IEnumerator DisplayMessageAndLoadLevel()
    {
        messageText.text = "Object Recovered!";
        messageText.gameObject.SetActive(true); 

        yield return new WaitForSeconds(delayBeforeLoading); 

        messageText.gameObject.SetActive(false); 
        SceneManager.LoadScene(levelToLoad); 
    }
}