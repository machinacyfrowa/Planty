using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaShooterBehaviour : MonoBehaviour
{
    public GameObject projectile;

    float timeSinceLastShot;
    float shotInterval = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        if(timeSinceLastShot >= shotInterval && hit.collider != null)
        {
            GameObject p = Instantiate(projectile, transform.position, Quaternion.identity);
            Destroy(p, 5);
            timeSinceLastShot = 0;
        }
        timeSinceLastShot += Time.deltaTime;
    }
}
