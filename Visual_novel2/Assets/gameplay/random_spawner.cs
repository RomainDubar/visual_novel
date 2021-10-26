using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random_spawner : MonoBehaviour
{
    public GameObject candy;
    public int numberCandy;
    internal int TheSpawnCandy;
    internal static int CandyInScene =0;
    internal static bool CanStealCandy;
    internal static bool miniGamePlay = false;
    public GameObject charasprite;
    public Sprite [] Sorciere;
    public Image img;
    public GameObject Onomat;


    //internal static GameObject Saveobject;
    //internal static GameObject TheOnomatop;
    private void Start()
    {
        //Saveobject = charasprite;
        //TheOnomatop = Onomat;
        CandyInScene = 0;
        TheSpawnCandy = numberCandy;

        //SpawnCandy();
    }
    void Update()
    {
        Minigame();
        if (CandyInScene ==0 & miniGamePlay == true)
        {
            TheSpawnCandy = numberCandy;
            
        }
        while (TheSpawnCandy != 0 & miniGamePlay == true)
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
        if (CanStealCandy == true)
        {
            counter.score = counter.score / 2;
            CandyInScene -= 1;


            //for (float i = 0; i <= 1; i += Time.deltaTime)
            //{
            //    // set color with i as alpha
            //    img.color = new Color(1, 1, 1, i);
            //}
        }




        else if (CanStealCandy == false)
        {
            counter.score += 5;
            CandyInScene -= 1;

        }





}

    public void Minigame()
    {
        int c = 0;
        while (c<Sorciere.Length)
        {
            if (charasprite.GetComponent<Image>().sprite == Sorciere[c])
            {
                miniGamePlay = true;
                return;
            }
            else
            {
                miniGamePlay = false;

            }
            Debug.Log(c);
            c = c + 1;
            
        }
        

        
    }

  

}
