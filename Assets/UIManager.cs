using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public Timer timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            timer.StopTimer(); // Para o cronômetro
            endGamePanel.SetActive(true);
        }
    }
}
