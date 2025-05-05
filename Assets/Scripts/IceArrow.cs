using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceArrow : Projectile
{
    public IceArrow()
    {

    }
    public IceArrow(Sprite iceArrowSprite)
    {
        this.damage = 10;
        this.speed = 15;
    }
    public override void Move()
    {
        rb.velocity = new Vector2(0, Mathf.Sin(Time.time) * speed);
    }
    public override void Hit(GameObject receiver)
    {
        float enemyHealth = receiver.GetComponent<Enemy>().health;
        receiver.GetComponent<Enemy>().ReceiveDamage(enemyHealth / 2);
        // Crea la variable enemyHealth que se haya accediendo a la vida del enemigo, y luego se divide la variable entre dos, para después ser aplicada en el método ReceiveDamage.
    }
}
