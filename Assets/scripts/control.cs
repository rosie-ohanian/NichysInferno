using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public int levelsStart;
    public int gameOver;
    private int lives = 1;
    public AudioClip[] music;
    private int m;
    public AudioSource play;

    void Start()
    {
        m = 1;
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

    public void nextMusic()
    {
        play.clip = music[m++];
        play.Play();
    }
}
