using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private float parallaxEffect;

    private float length, startPos;
    private GameObject camera;


    void Start()
    {
        camera = Camera.main.gameObject;
        startPos = transform.position.x;
        length = transform.GetComponentInChildren<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float temp = (camera.transform.position.x * (1 + parallaxEffect));
        float dist = (camera.transform.position.x * -parallaxEffect);
        transform.position = new Vector3(startPos + dist, -2, transform.position.z);
        if (temp > startPos + length) startPos += length;
        else if (temp < startPos - length) startPos -= length;
    }
}
