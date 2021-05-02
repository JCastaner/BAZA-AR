using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotScript : MonoBehaviour
{

    public GameObject SStext;
    float timer = 0.0f; // begins at this value
    float timerMax = 3.0f; // event occurs at this value

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy == true) //if text is active
        {
            timer += Time.deltaTime;

            if (timer >= timerMax) //if 3 seconds elapsed
            {
                SStext.SetActive(false); //turn off

                timer = 0.0f;
            }
        }
    }
	
	public void ScreenSh()
    {
        ScreenCapture.CaptureScreenshot("screenshot"); //screenshot
    }
}
