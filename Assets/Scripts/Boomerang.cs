using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boomerang : Projectile
{
    private float timeToReturn, currentTime;

    public Boomerang()
    {
        // Constructor vacío.
    }
    public Boomerang(Sprite boomSprite, float timeToReturn, Rigidbody2D rb) : base(10, 8, rb, boomSprite)
    {
        this.timeToReturn = timeToReturn;
        this.rb = rb;
    }

    public override void Move()
    {
        rb.velocity = Vector2.up * Time.deltaTime;
        if (currentTime >= timeToReturn)
        {
            rb.velocity = -rb.velocity * Time.deltaTime;
            rb.rotation = speed * Time.deltaTime;
        }
    }
}
