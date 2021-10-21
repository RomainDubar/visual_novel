using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_spawner : MonoBehaviour
{
    public GameObject candy;
    public counter Counter;

    private void Start()
    {
        SpawnCandy();
    }
    void Update()
    {
      
    }

    public void SpawnCandy()
    {
        bool candyspawn = false;
        while (!candyspawn)
        {
            Counter.score += 5;
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
        Destroy(gameObject);
        
    }

    //void OnMouseDown()
    //{
    //    Destroy(gameObject);

    //    SpawnCandy();
    //}

}
