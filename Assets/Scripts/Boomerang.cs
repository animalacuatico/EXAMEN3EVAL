using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boomerang : Projectile
{
    private float timeToReturn = 2, currentTime;

    public Boomerang()
    {
        // Constructor vacío.
    }
    public Boomerang(Sprite boomSprite, float timeToReturn, Rigidbody2D rb) : base(10, 8, Resources.Load<Sprite>("./Resources/Boomerang"), rb)
    {
        this.timeToReturn = timeToReturn;
    }

    public override void Move()
    {
        rb.velocity = Vector2.up;
        currentTime = Time.deltaTime;
        if (currentTime >= timeToReturn)
        {
            rb.velocity = Vector2.down;
            rb.rotation = speed;
        }
    }
}
