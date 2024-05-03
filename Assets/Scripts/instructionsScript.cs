using UnityEngine;
using UnityEngine.SceneManagement;



public class instructionsScript : MonoBehaviour
{
    // Function to be called when the 'Start Game' button is clicked
    public void LoadScene()
    {
        SceneManager.LoadScene("Instructions");
    }

    // Function to be called when the 'Quit Game' button is clicked
    public void QuitGame()
    {
        Application.Quit();
    }
}
