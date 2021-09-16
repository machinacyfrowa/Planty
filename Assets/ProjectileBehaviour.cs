using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    GameObject target;
    ZombieBehaviour targetScript;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 v = new Vector2(200, 0);  // Vector2.right*50;
        transform.GetComponent<Rigidbody2D>().AddForce(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D targetColider)
    {
        target = targetColider.gameObject;
        targetScript = target.GetComponent<ZombieBehaviour>();
        targetScript.GetHit();
        //to samo w jednej linii
        //targetColider.gameObject.GetComponent<ZombieBehaviour>().GetHit();
        Destroy(transform.gameObject);
    }
}
