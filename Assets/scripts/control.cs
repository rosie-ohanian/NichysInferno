using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    private string currentScene = "practice";

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(currentScene);
    }
}
