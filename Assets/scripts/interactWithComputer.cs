using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactWithComputer : MonoBehaviour
{
    public GameObject wall;
    private Boolean active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            active = true;
            wall.SetActive(false);
        }
    }
}
