using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject zombie;

    float spawnInterval = 1;
    float timeSinceLastSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timeSinceLastSpawn >= spawnInterval)
        {
            int[] lanes = new int[] { -4, -2, 0, 2, 4 };
            int randomIndex = Random.Range(0, lanes.Length);
            Instantiate(zombie, new Vector3(10, lanes[randomIndex], 0), Quaternion.identity);
            timeSinceLastSpawn = 0;
        }
        timeSinceLastSpawn += Time.deltaTime;
    }
}
