using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moveBlock : MonoBehaviour
{
    public GameObject leftBoundrie;
    public GameObject rightBoundrie;
    public bool startRight;
    public Collider2D block;
    public int speed;
    private float move;

    // Start is called before the first frame update
    void Start()
    {
        if (startRight) {
            move = (speed / 1000f);
        } else
        {
            move = -(speed / 1000f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        block.transform.position = new Vector3(block.transform.position.x + move, block.transform.position.y, 0);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.Equals(rightBoundrie) && (move > 0)) {
            move = -(speed / 1000f);
        }
        if (c.gameObject.Equals(leftBoundrie) && (move < 0))
        {
            move = (speed / 1000f);
        }
    }
}
