using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchScript : MonoBehaviour
{
    public Text text; //text
    bool status, fadeIn; //status and fade

    // Start is called before the first frame update
    void Start()
    {
		//set to false
        status = false;
        fadeIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (status == false) //if not currently fading
        {
            status = true;
            StartCoroutine(wait()); //wait 2 seconds
            status = false;
        }
    }

    IEnumerator wait()
    {
        if (fadeIn == true)
        {
            text.CrossFadeAlpha(0, 0.5f, false); //fade out
        }
        else if (fadeIn == false)
        {
            text.CrossFadeAlpha(1, 0.5f, false); //fade in
        }

        fadeIn = !fadeIn;

        return new WaitForSecondsRealtime(2);
    }
}
