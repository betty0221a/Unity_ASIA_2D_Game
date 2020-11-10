
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour 
{
    public void NextLevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);   
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

