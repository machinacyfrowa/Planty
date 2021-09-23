using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{
    public int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 50);                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (transform.position.x < -11)
            Camera.main.GetComponent<GameManager>().gameOver();
    }
    public void GetHit()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(transform.gameObject);
            Camera.main.GetComponent<GameManager>().addPoints(100);
        }
            
    }
}
