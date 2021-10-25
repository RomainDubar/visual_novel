using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Disable_Dialog : MonoBehaviour
{
    public GameObject spritePlayer;
    public Sprite StadeUn;
    //public Sprite StadeDeux;
    public GameObject [] spriteTodisable ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spritePlayer.GetComponent<Image>().sprite == StadeUn)
        {
            for (int i = 0; i < spriteTodisable.Length; i++)
            {
                spriteTodisable[i].SetActive(false);
            }
            
            

        }

        else
        {
            for (int i = 0; i < spriteTodisable.Length; i++)
            {
                spriteTodisable[i].SetActive(true);
            }
        }
    }
}
