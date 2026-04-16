using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class playerControle : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    public float jump;
    //public Collider2D groundCollider;
    private float horizontal;
    private bool touchingGround = true;
    private float boost = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && touchingGround)
        {
            Debug.Log("JUMPPPPPPPPPPPPPPPPPPPPPP");
            player.velocity = new Vector2(player.velocity.y, jump);
            touchingGround = false;
        }
    }
    private void FixedUpdate()
    {
        // Apply horizontal movement to Rigidbody velocity
        player.velocity = new Vector2(horizontal * speed + boost, player.velocity.y);
        boost = 0;
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log(c.gameObject.tag);
        if (c.gameObject.tag.Equals("hazard"))
        {
            Debug.Log("qwehrgkwr");
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

        if (c.gameObject.CompareTag("movingGround"))
        {
            //Debug.Log(c.rigidbody);
            //Debug.Log(c.rigidbody.velocity);
            boost = c.rigidbody.velocity.x;
            Debug.Log(boost);
        }
    }
}

