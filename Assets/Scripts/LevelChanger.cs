using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Añade esto si estás usando TextMeshPro para el mensaje
using System.Collections; // Esto es necesario para usar coroutinas

public class LevelChanger : MonoBehaviour
{
    public string levelToLoad = "Level1";
    public TextMeshProUGUI messageText; // Asegúrate de que esta referencia está asignada en el Inspector
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
        messageText.text = "Mariachi Recover!";
        messageText.gameObject.SetActive(true); // Muestra el mensaje

        yield return new WaitForSeconds(delayBeforeLoading); // Espera un poco antes de cambiar de escena

        messageText.gameObject.SetActive(false); // Opcional: Oculta el mensaje
        SceneManager.LoadScene(levelToLoad); // Carga la nueva escena
    }
}