using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerControle : MonoBehaviour
{
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.velocityX = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.velocityX = -1;
        }
    }
}
