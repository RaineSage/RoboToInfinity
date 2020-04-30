using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [SerializeField]
    private PlayerStats stats;

    private Rigidbody2D rig;

    void Start()
    {
        StartCoroutine(stats.addHealth(1f));
        StartCoroutine(stats.addEnergy(1f));

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
    }
}
