using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sprite_detect : MonoBehaviour
{
    public static int Stopcandy;
    public GameObject thesprite;
    public Sprite StadeUn;
    public Sprite StadeDeux;


    public float temps = 10;
    public int tempsint;
    private float Savetemps;
    // Start is called before the first frame update
    void Start()
    {
        Savetemps = temps;
    }

    // Update is called once per frame
    void Update()
    {
        //tempsint = Mathf.RoundToInt(temps);
        if(temps >= Savetemps/2)
        {
            temps -= Time.deltaTime;
            thesprite.GetComponent<Image>().sprite = StadeUn;
            random_spawner.CanStealCandy = false;
        }

        else if (temps < Savetemps / 2 )
        {
            temps -= Time.deltaTime;
            thesprite.GetComponent<Image>().sprite = StadeDeux;
            random_spawner.CanStealCandy = true;
        }

        if (temps <= 0)
        {
            temps = Savetemps;
        }



        //if (thesprite.GetComponent<Image>().sprite == StadeUn)
        //{
        //    random_spawner.CanStealCandy = false; 

        //    //thesprite.GetComponent<Image>().sprite = StadeDeux;

        //}

        //else if (thesprite.GetComponent<Image>().sprite == StadeDeux)
        //{
        //    random_spawner.CanStealCandy = true;

        //    //thesprite.GetComponent<Image>().sprite = StadeDeux;

        //}
    }
}
