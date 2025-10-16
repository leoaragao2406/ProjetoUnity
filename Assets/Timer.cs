using UnityEngine;
using TMPro; // Adicione esta linha

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Troque Text por TMP_Text
    public float timeElapsed = 0f;
    public bool isRunning = false;

    void Update()
    {
        if (isRunning)
        {
            timeElapsed += Time.deltaTime;
            timerText.text = timeElapsed.ToString("F2") + "s";
        }
    }

    public void DecreaseTime(float amount)
    {
        timeElapsed = Mathf.Max(0f, timeElapsed - amount);
    }

    public void StartTimer()
    {
        timeElapsed = 0f;
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}