using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class launch : MonoBehaviour
{
    public float rate;
    private float timer;
    public GameObject projectile;
    private float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 60 / rate;
        timer = 0;
        Instantiate(projectile, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        if (timer < t)
        {
            timer += Time.deltaTime;
        }
        else
        {
            create();
            timer = 0;
        }
    }

    void create()
    {
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
