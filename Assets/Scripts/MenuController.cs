using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Function to be called when the 'Start Game' button is clicked
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    // Function to be called when the 'Quit Game' button is clicked
    public void QuitGame()
    {
        Application.Quit();
    }
}