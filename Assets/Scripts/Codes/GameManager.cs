using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool GamaHasEnded = false;
    public float TimeDelay = 1f;
    public GameObject NextLevel;

    public void CompleteLevel()
    {

        NextLevel.SetActive(true);

    }
    public void EndGame()
    {
        if (GamaHasEnded == false)
        {
            GamaHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", TimeDelay);
        }
    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
