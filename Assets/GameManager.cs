using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameSquare;
    public GameObject zombie;

    public GameObject peaShooter;

    public UnityEngine.UI.Text cashCounter;
    public GameObject gameOverPanel;
    
    int cash = 5000;
    float spawnInterval = 1;
    float timeSinceLastSpawn;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = -10; x <=10; x+=2)
        {
            for(int y= -4; y <= 4; y += 2)
            {
                Debug.Log("Tworze pole");
                GameObject square = Instantiate(gameSquare, new Vector3(x, y, 0), Quaternion.identity);
                if((x+y) % 4 == 0)
                    square.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0.2f);
            }
        }
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
        cashCounter.text = "Punkty: " + cash.ToString();
    }
    public void placePlant(Vector3 position)
    {
        if(cash >= 1000)
        {
            Instantiate(peaShooter, position, Quaternion.identity);
            cash -= 1000;
        }
        
    }
    public void addPoints(int ammount) 
    {
        cash += ammount;
    
    }
    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }
}
