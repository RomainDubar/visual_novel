using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject counter;
    public random_spawner RandomSpawner;
  
    void OnMouseDown()
    {
        //RandomSpawner.SpawnCandy();
        
        //Counter.Collect();
        //counter.GetComponent<random_spawner>().CandyInScene -= 1;
        //Debug.Log(RandomSpawner.CandyInScene);
        RandomSpawner.DestroyCandy();
        Destroy(gameObject);

    }
}
