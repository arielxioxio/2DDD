
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
    public void NextLevel(string newlv) 
    {
        SceneManager.LoadScene(newlv);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");}
    public void Quit()
    {
        Application.Quit();
    }
}



