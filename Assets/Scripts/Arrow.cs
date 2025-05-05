using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectile
{
    public Arrow()
    {
        // Constructor vacío.
    }
    public Arrow(Sprite arrowSprite)
    {
        this.damage = 25;
        this.speed = 30;
    }
    public override void Move()
    {
        rb.velocity = Vector2.up;
    }

}
