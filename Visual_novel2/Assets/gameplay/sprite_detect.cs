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
    internal static Sprite spriteSave;


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
        if (thesprite.GetComponent<Image>().sprite != StadeUn)
        {
            spriteSave = thesprite.GetComponent<Image>().sprite;
        }
        
        if (random_spawner.miniGamePlay == true)
        {
            if (temps >= Savetemps / 2)
            {
                temps -= Time.deltaTime;
                thesprite.GetComponent<Image>().sprite = StadeUn;
                random_spawner.CanStealCandy = false;
                GameObject.Find("spawner").GetComponent<random_spawner>().Onomat.SetActive(false);
            }

            else if (temps < Savetemps / 2)
            {
                temps -= Time.deltaTime;
                thesprite.GetComponent<Image>().sprite = spriteSave;
                random_spawner.CanStealCandy = true;
                

            }

            if (temps <= 0)
            {
                temps = Savetemps;
            }
        }
        else
        {

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
