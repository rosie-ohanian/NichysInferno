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
    private float horizontal;
    private bool touchingGround = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.UpArrow)) && touchingGround)
        {
            Debug.Log("JUMPPPPPPPPPPPPPPPPPPPPPP");
            player.velocity = new Vector2(player.velocity.y, jump);
            touchingGround = false;
        }
    }
    private void FixedUpdate()
    {
        // Apply horizontal movement to Rigidbody velocity
        player.velocity = new Vector2(horizontal * speed, player.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log(c.gameObject.tag);
        if (c.gameObject.tag.Equals("hazard"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    void OnCollisionStay2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("ground"))
        {
            foreach (ContactPoint2D contact in c.contacts)
            {
                if (contact.normal.y >= 0.9f)
                {
                    touchingGround = true;
                    break;
                }
            }
        }
    }
}

