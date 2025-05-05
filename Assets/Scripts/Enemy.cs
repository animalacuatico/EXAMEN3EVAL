using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float health = 100;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().gameObject;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            target.transform.position, speed * Time.deltaTime);
    }

    public void ReceiveDamage(float dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
