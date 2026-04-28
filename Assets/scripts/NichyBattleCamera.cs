using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NichyBattleCamera : MonoBehaviour
{
    public Camera Camera;
    public RectTransform panel;
    public Transform level;
    public Rigidbody2D player;
    public float panelspeed;
    public float levelspeed;
    public float yspeed;
    private Vector3 ypos;
    private float xpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ypos = (Vector3.up * yspeed * Time.deltaTime * (2 * (Camera.transform.InverseTransformPoint(player.transform.position).y + Camera.orthographicSize + 5) / (Camera.orthographicSize * 2f)));
        Camera.transform.Translate(ypos);
        panel.transform.Translate(-ypos);
        xpos = -(Camera.transform.InverseTransformPoint(player.transform.position).x / (Camera.orthographicSize * 2));
        panel.anchoredPosition = new Vector2(xpos / panelspeed, panel.anchoredPosition.y);
        level.position = new Vector2(xpos / levelspeed, level.position.y);
    }
}
