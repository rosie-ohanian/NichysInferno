using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class playerControle : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    public float jump;
    public Collider2D groundCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.velocityX = speed;
        } else if(player.velocityX > 0) 
        {
            player.velocityX -= 1;

            if(player.velocityX < 0)
            {
                player.velocityX = 0;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocityX = -speed;
        } else if (player.velocityX < 0)
        {
            player.velocityX += 1;

            if (player.velocityX > 0)
            {
                player.velocityX = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && player.IsTouching(groundCollider)) 
        { 
            player.velocityY = jump;
        }
        */
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            player.AddForce(new Vector2(speed, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            player.AddForce(new Vector2(-speed, 0));
        }
        if (player.IsTouching(groundCollider) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)))
        {
            player.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log(c.gameObject.tag);
        if (c.gameObject.tag.Equals("hazard")) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (c.gameObject.tag.Equals("ground")){

        }
    }
}
