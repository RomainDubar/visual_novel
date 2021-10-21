using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public random_spawner RandomSpawner;
    public counter Counter;
    void OnMouseDown()
    {
        RandomSpawner.SpawnCandy();
        Destroy(gameObject);
        Counter.Collect();

        //RandomSpawner.DestroyCandy();

    }
}
