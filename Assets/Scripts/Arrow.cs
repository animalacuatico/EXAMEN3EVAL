using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectile
{
    public Arrow()
    {
        // Constructor vacío.
    }
    public Arrow(Sprite arrowSprite, Rigidbody2D rb) : base(30, 25, Resources.Load<Sprite>("./Resources/arrow"), rb)
    {
        this.rb = rb;
    }
    public override void Move()
    {
        rb.velocity = Vector2.up;
    }

}
