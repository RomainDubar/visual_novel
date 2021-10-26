using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource bonson;
    // Start is called before the first frame update
    public void playSound ()
    {
        bonson.Play();
        //Button b = GetComponent<Button>();
        //AudioSource audio = GetComponent<AudioSource>();
        //b.onClick.AddListener(delegate () { audio.Play(); });
    }
}
