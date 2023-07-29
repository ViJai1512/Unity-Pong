using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colusioncontrol : MonoBehaviour
{
    public ballmove ballmove;
    public scorecontrol scorecontrol;
    void BouceFromRacket(Collision2D c)
    {
        Vector3 ballposition = this.transform.position;
        Vector3 racketposition = c.gameObject.transform.position;

        float racketheight = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "play1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballposition.y - racketposition.y) / racketheight;

        this.ballmove.increasesoeed();
        this.ballmove.ballmoive(new Vector2 (x, y));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "play1" || collision.gameObject.name == "play2" )
        {
            this.BouceFromRacket (collision);
        }
        else if(collision.gameObject.name == "Cube2")
        {
            Debug.Log("Collusion with wallLeft");
            this.scorecontrol.GoalPlayer2();
           StartCoroutine(ballmove.Startball(true));
        }
        else if (collision.gameObject.name == "Cube3")
        {
            Debug.Log("Collusion with wallright");
            this.scorecontrol.GoalPlayer1();
           StartCoroutine(ballmove.Startball(false));
        }
    }
}
