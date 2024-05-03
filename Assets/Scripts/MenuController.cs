using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Function to be called when the 'Start Game' button is clicked
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

        public void StartIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}