using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float range;

    void Start()
    {
        Destroy(gameObject, range);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x + (Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad) * speed), transform.position.y + (Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad) * speed), transform.position.z);
    }
}
