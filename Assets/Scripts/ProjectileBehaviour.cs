using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
public class ProjectileBehaviour : MonoBehaviour
{
    public float aliveTime = 5;
  
    private float currentTime = 0;

    private Projectile projectile;

    public ProjectileType typeofProj;

    private Rigidbody2D RB2D;

    private SpriteRenderer spriteRenderer;

    public Sprite icearrow, arrow, boomerang;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        RB2D = GetComponent<Rigidbody2D>();
        if (typeofProj == ProjectileType.ARROW)
        {
            projectile = new Arrow(arrow, RB2D);
            spriteRenderer.sprite = arrow;
        }
        else if (typeofProj == ProjectileType.ICEARROW)
        {
            projectile = new IceArrow(icearrow, RB2D);
            spriteRenderer.sprite = icearrow;
        }
        else if (typeofProj == ProjectileType.BOOMERANG)
        {
            projectile = new Boomerang(boomerang, 2, RB2D);
            spriteRenderer.sprite = boomerang;
        }
    }
    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > aliveTime) 
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        projectile.Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Enemy>())
        {
            GameObject enemy = FindObjectOfType<Enemy>().gameObject;
            projectile.Hit(enemy);
        }
    }
}
