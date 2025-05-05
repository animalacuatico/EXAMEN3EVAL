using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float aliveTime = 5;
  
    private float currentTime = 0;
    void Start()
    {
       
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

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Enemy>())
        {

        }
    }
}
