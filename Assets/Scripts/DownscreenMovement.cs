using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownscreenMovement : MonoBehaviour
{
    public float speed = 20f;
    public Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        float theta = Random.Range(90 + 1, 180-1);
        dir = new Vector3(Mathf.Cos(theta*2*Mathf.PI/180), Mathf.Sin(theta*2*Mathf.PI/180), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + dir*speed*Time.deltaTime;
    }
}
