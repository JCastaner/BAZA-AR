using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonScript : MonoBehaviour
{
    public Button backButton; //back button
    public string load3; //scene to load
	
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(load3scene); //tether buttons
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void load3scene()
    {
        SceneManager.LoadScene(load3); //load specified scene
    }
}
