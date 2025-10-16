using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAction : MonoBehaviour
{

    public void StartGame()
    {
        GameController.Init();
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
