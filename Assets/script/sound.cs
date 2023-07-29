using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource wallsound;
    public AudioSource racketsound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "play1" || collision.gameObject.name == "play2")
        {
            this.racketsound.Play();
        }
        else
        {
            this.wallsound.Play();
        }
    }
}
