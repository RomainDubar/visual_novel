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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thesprite.GetComponent<Image>().sprite == StadeUn)
        {
            
            thesprite.GetComponent<Image>().sprite = StadeDeux;
            
        }
    }
}
