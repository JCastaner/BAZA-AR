using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour
{
    public Button startButton, levelButton, backButton; //buttons
    public string load1, load2, load3; //scenes to load

    // Start is called before the first frame update
    void Start()
    {
		//tether buttons
        startButton.onClick.AddListener(StartGame);
        levelButton.onClick.AddListener(TriggerLevelSelect);
        backButton.onClick.AddListener(load3scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//LOAD SCENES
    void StartGame()
    {
        SceneManager.LoadScene(load1);
    }

    void TriggerLevelSelect()
    {
        SceneManager.LoadScene(load2);
    }

    void load3scene()
    {
        SceneManager.LoadScene(load3);
    }
}
