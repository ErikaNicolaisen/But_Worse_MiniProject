using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartGame()
    {
        Debug.Log("Restart button clicked");
        PlayerHealth.isPlayerAlive = true;
        ScoreManager.instance = null;
        SceneManager.LoadScene("SampleScene");
    }
}
