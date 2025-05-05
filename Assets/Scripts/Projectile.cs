using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile
{

    protected float speed, damage;
    protected Rigidbody2D rb;
    private Sprite sprite;

    public Projectile()
    {

    }

    public Projectile(float speed, float damage, Sprite sprite, Rigidbody2D rb)
    {
        this.speed = speed;
        this.damage = damage;
        this.sprite = sprite;
        this.rb = rb;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }
    public abstract void Move();

    public virtual void Hit(GameObject receiver)
    {
        receiver.GetComponent<Enemy>().ReceiveDamage(damage);
    }
}
