using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSceneScript : MonoBehaviour
{
    public Button Tutorial, Poster, Furniture, Back; //buttons

    // Start is called before the first frame update
    void Start()
    {
		//tether buttons
        Tutorial.onClick.AddListener(TutorialLoad);
        Poster.onClick.AddListener(Level1Load);
        Furniture.onClick.AddListener(Level2Load);
        Back.onClick.AddListener(Level4Load);
    }

    // Update is called once per frame
    void Update()
    {

    }
	
	//HARD CODED SCENE NAMES FROM HERE DOWNWARDS
    void TutorialLoad()
    {
        SceneManager.LoadScene("Menu2");
    }

    void Level1Load()
    {
        SceneManager.LoadScene("Menu3Posters");
    }

    void Level2Load()
    {
        SceneManager.LoadScene("Menu3Furniture");
    }

    void Level3Load()
    {
        SceneManager.LoadScene("DisplayScene"); // UNUSED
    }

    void Level4Load()
    {
        SceneManager.LoadScene("Menu");
    }
}
