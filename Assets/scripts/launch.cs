using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class launch : MonoBehaviour
{
    public float rate;
    public float speed;
    public float range;
    private float timer;
    private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
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
        float point = transform.position.y + Random.Range(-1 * distance, distance);
        Instantiate(pipe, new Vector3(transform.position.x, point, transform.position.z), transform.rotation);
    }
}
