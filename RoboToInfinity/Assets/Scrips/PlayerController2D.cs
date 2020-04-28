using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 1 )
        {
            rig.AddForce(Vector2.right * 2);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            rig.AddForce(-Vector2.right * 2);
        }
        Debug.Log(Input.GetAxisRaw("Horizontal"));
    }
}
