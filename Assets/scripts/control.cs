using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public int levelsStart;
    public int gameOver;
    public int lives = 1;

    void Start()
    {
        Debug.Log("ddol gonnna load");
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(levelsStart);
    }

    public void die()
    {
        Debug.Log("you died");
        lives = lives - 1;
        if(lives >= 0)
        {
            Debug.Log("respawn");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else
        {
            int next = gameOver;
            Debug.Log(next);
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            Debug.Log("game over");
            SceneManager.LoadScene(next);
        }
    }
}
