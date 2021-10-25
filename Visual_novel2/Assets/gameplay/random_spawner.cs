using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_spawner : MonoBehaviour
{
    public GameObject candy;
    public int numberCandy;
    private int TheSpawnCandy;
    internal static int CandyInScene =0;
    internal static bool CanStealCandy;


    private void Start()
    {
        CandyInScene = 0;
        TheSpawnCandy = numberCandy;

        //SpawnCandy();
    }
    void Update()
    {
        
        if (CandyInScene ==0)
        {
            TheSpawnCandy = numberCandy;
            
        }
        while (TheSpawnCandy != 0)
        {
            SpawnCandy();
            TheSpawnCandy -= 1;

        }

    }

    public void SpawnCandy()
    {
        

        CandyInScene += 1;
        bool candyspawn = false;
        while (!candyspawn)
        {
            
            Vector3 candyPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((candyPosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(candy, candyPosition, Quaternion.identity);
                candyspawn = true;
            }
        }
    }

    public void DestroyCandy()
    {
        if (CanStealCandy == true )
        {
            counter.score += 5;
            CandyInScene -= 1;
            
        }
        else if (CanStealCandy == false )
        {
            counter.score = counter.score / 2;
            CandyInScene -= 1;

        }
        
        
        
        //Debug.Log(Counter.GetComponent<counter>().score);

    }

    //void OnMouseDown()
    //{
    //    Destroy(gameObject);

    //    SpawnCandy();
    //}

}
