using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ends : MonoBehaviour
{
    public GameObject Background;
    public Sprite TheEnd;
    public Sprite EndOne;
    public Sprite EndTwo;
    public Sprite EndThree;
    public int valueChangeEnd;


    // Update is called once per frame
    void Update()
    {
        while (Background.GetComponent<Image>().sprite == TheEnd)
        {
            if (counter.score > valueChangeEnd)
            {
                Background.GetComponent<Image>().sprite = EndOne;
            }
            else if (counter.score == valueChangeEnd)
            {
                Background.GetComponent<Image>().sprite = EndTwo;
            }
            else if (counter.score < valueChangeEnd)
            {
                Background.GetComponent<Image>().sprite = EndThree;
            }
        }
        
    }
}
