using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public GameObject counter;
    public random_spawner RandomSpawner;

    private void Start()
    {
    }
    void OnMouseDown()
    {
        RandomSpawner.DestroyCandy();
        Destroy(gameObject);
        GameObject.Find("spawner").GetComponent<random_spawner>().Onomat.SetActive(true);
        if (sprite_detect.temps >= sprite_detect.Savetemps / 2)
        {
            GameObject.Find("GoodBonbon").GetComponent<AudioSource>().Play(0);
        }

        if (sprite_detect.temps < sprite_detect.Savetemps / 2)
        {
            GameObject.Find("BadBonbon").GetComponent<AudioSource>().Play(0);
        }




    }
}
