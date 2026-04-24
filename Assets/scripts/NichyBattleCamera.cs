using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NichyBattleCamera : MonoBehaviour
{
    public Camera Camera;
    public RectTransform panel;
    public Rigidbody2D player;
    public float speed;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = Vector3.up * speed * Time.deltaTime;
        Camera.transform.Translate(pos * (2 * (Camera.transform.InverseTransformPoint(player.transform.position).y + Camera.orthographicSize+5)/(Camera.orthographicSize * 2f)));
        panel.transform.Translate(pos * (-2 * (Camera.transform.InverseTransformPoint(player.transform.position).y + Camera.orthographicSize+5) / (Camera.orthographicSize * 2f)));

    }
}
