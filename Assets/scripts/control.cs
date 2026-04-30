using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    private string currentScene = "practice";
    private int lives = 1;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(currentScene);
    }

    public bool die()
    {
        Debug.Log("you died");
        lives = lives - 1;
        if(lives >= 0)
        {
            Debug.Log("respawn");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else
        {
            Debug.Log("game over");
            SceneManager.LoadScene("gameOver");
        }
        print(lives);
        return lives >= 0;
    }
}
