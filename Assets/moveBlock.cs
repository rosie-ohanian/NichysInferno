using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{
    public Collider2D leftBoundrie;
    public Collider2D rightBoundrie;
    public bool startRight;
    public Collider2D block;
    public float speed;
    private float move;

    // Start is called before the first frame update
    void Start()
    {
        if (startRight) {
            move = speed;
        } else
        {
            move = -speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        block.transform.position = new Vector3(block.transform.position.x + move, block.transform.position.y, 0);
        if(block.IsTouching(rightBoundrie)) {
            move = -speed;
            Debug.Log("touching boarder");
        }
    }

    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.Equals(rightBoundrie) && (move > 0)) {
            move = -speed;
            block.position = new Vector3(block.position.x - 1, block.position.y, 0);
            Debug.Log("touching boarder");
        }
        if (collision.gameObject.Equals(leftBoundrie) && (move < 0))
        {
            move = speed;
            block.position = new Vector3(block.position.x + 1, block.position.y, 0);
            Debug.Log("touching boarder");
        }
    }
    */
}
