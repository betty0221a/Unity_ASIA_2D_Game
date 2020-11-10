
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmaneger : MonoBehaviour 
{
    public void Nextlevel()
    {

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("遊戲選單");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

