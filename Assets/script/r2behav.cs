using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r2behav : MonoBehaviour
{
    public float movespeed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movespeed;
    }

}
