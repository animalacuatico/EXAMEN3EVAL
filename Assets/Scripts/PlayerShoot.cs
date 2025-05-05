using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ProjectileType { ICEARROW, ARROW, BOOMERANG }
public class PlayerShoot : MonoBehaviour
{
    public float timeToShoot = 0.4f;
    public GameObject projectile;
    private float currentTime = 0;
    private Projectile Projectile;
    private int counter = 0;
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0)) 
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            Debug.Log(counter);
            currentTime = 0;
        }
        // Cada vez que se presiona el espacio, se 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            if (counter == 3)
            {
                counter = 0;
            }
        }
        switch (counter)
        {
            case 0:
                Projectile = new Arrow();
                break;
            case 1:
                Projectile = new IceArrow();
                break;
            case 2:
                Projectile = new Boomerang();
                break;
        }
    }
}
