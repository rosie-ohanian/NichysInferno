using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveBarScript : MonoBehaviour
{
    public GameObject manager;
    public Slider slideyBoi;
    public Image health;
    private double steps;


    // Start is called before the first frame update
    void Start()
    {
        slideyBoi.maxValue = manager.GetComponent<control>().lives;
        health.color = Color.green;
        steps = 255/slideyBoi.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        slideyBoi.value = manager.GetComponent<control>().lives;
        health.color = new Color32((byte)(255 - (steps * slideyBoi.value)), (byte)(steps * slideyBoi.value), 0, 255);
    }
}
