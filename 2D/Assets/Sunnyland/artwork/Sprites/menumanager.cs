using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public void Startgame()
    {
        print("Start game");
        SceneManager.LoadScene(1);
    }
    public void Quitgame()
    {
        print("Quit game");
        Application.Quit();
    }
}
