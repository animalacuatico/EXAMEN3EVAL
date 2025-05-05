using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ProjectileType { ARROW, ICEARROW, BOOMERANG }
public class PlayerShoot : MonoBehaviour
{
    public float timeToShoot = 0.4f;
    public GameObject projectile;
    private float currentTime = 0;
    private Projectile Projectile;
    private ProjectileType ProjectileType;
    private int counter = 0;
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0)) 
        {
            GameObject projectileClone = Instantiate(projectile, transform.position, Quaternion.identity);
            projectileClone.GetComponent<ProjectileBehaviour>().typeofProj = ProjectileType;
            currentTime = 0;
        }
        // Cada vez que se presiona el espacio, se suma uno al contador, por lo tanto da vueltas en un ciclo del 0 al 2.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            if (counter == 3)
            {
                counter = 0;
            }
        }
        // Cada vez que cambia el contador, se cambia el tipo de proyectil al siguiente.
        switch (counter)
        {
            case 0:
                ProjectileType = ProjectileType.ARROW;
                break;
            case 1:
                ProjectileType = ProjectileType.ICEARROW;
                break;
            case 2:
                ProjectileType = ProjectileType.BOOMERANG;
                break;
        }
    }
}
