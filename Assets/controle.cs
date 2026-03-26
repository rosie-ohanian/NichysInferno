using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public GameObject ground;
    private int[,] array;

    // Start is called before the first frame update
    void Start()
    {
        array = new int[4, 3];


        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(i);
            for(int j = 0; j < array.GetLength(i); j++)
            {
                Console.Write("," + j);
                if (array[i, j] == 0)
                {
                    createBlock(j, i);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createBlock(int x, int y)
    {
        Instantiate(ground, new Vector3(x * 10, y * 10, 0), transform.rotation);
    }
}
