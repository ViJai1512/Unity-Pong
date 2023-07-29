using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    public float movementspeed;
    public float addspeed;
    public float maxspeed;
    int count = 0;
    void Start()
    {
        StartCoroutine(this.Startball());
    }

    void PositionBall(bool isstartplayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isstartplayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-24, -151, 6);

        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(24, -151, 6);
        }
    }
    public IEnumerator Startball(bool startplayer1 = true)
    {
        this.PositionBall(startplayer1);

        this.count = 0;
        yield return new WaitForSeconds(2);
        if (startplayer1)
            this.ballmoive(new Vector2(-1, 0));
        else
        {
            this.ballmoive(new Vector2(1, 0));
        }

       
    }

   public void ballmoive(Vector2 dir) 
   {

        dir=dir.normalized;
        float speed = this.movementspeed + this.count * this.addspeed;
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed;
   }

   public void increasesoeed()
    {
        if (this.count * this.addspeed <= this.maxspeed)
        {
            this.count++;
        }
    }
}
