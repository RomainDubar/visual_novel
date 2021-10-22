using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class counter : MonoBehaviour
{
    public static int score;
    public Text AfficheScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AfficheScore.text = score.ToString();
    }

    public void Collect()
    {
        score += 5;
    }
}
