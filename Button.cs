using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;



//this C# file is used to control the function of buttons
public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this method is for the button which name is "start", when player click the "start" button, he will
    //go to the second scene, which is the level 1 of this game
    public void change_1()
    {
        SceneManager.LoadScene(1);
    }

    //this method is for the button which name is "menu", when player click the "menu" button, he will
    //go back to the first scene, which is the openning of this game
    public void change_2()
    {
        SceneManager.LoadScene(0);
    }

    //public void exit_1(){
        
      //  UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
        

    //}

    
}
