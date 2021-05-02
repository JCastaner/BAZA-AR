using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMenuScript : MonoBehaviour
{
    public GameObject pauseMenu, searchMenu; //menus
    public Button pauseButton, unPauseButton; //buttons

    // Start is called before the first frame update
    void Start()
    {
		//tether buttons
        pauseButton.onClick.AddListener(pauseApp);
        unPauseButton.onClick.AddListener(unPauseApp);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void pauseApp()
    {
		//pause menu, deactivate other menus
        searchMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    void unPauseApp()
    {
		//reactivate other text
        searchMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
}
