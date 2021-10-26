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


    public static float temps = 10;
    public int tempsint;
    internal static float Savetemps;
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
                //GameObject.Find("BadBonbon").GetComponent<AudioSource>().Play(0); ;

            }

            else if (temps < Savetemps / 2)
            {
                temps -= Time.deltaTime;
                thesprite.GetComponent<Image>().sprite = spriteSave;
                random_spawner.CanStealCandy = true;
                //GameObject.Find("GoodBonbon").GetComponent<AudioSource>().Play(0); 



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
