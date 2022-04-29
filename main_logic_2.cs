using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//this c# file is the main control script of the level_2 of the game
public class main_logic_2 : MonoBehaviour
{
    public int score =51; //the variable of the score of the player
    public Text scoreText; //the Text variable

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //control the fps of the game to 60
    }

    // Update is called once per frame
    void Update()
    {
        //in each frame of the game, it is judged whether the score of the player has reached 114 or not
        //if player reached 114, then he will go to the "win scene" of the game
        if(scoreText.text.Equals("105")){
            SceneManager.LoadScene(3);
        }
        
    }
    //this method is for add 3 score for player when he destroy a planet
    public void AddScore_1(){
        score +=3;
        scoreText.text =""+score;
    }
    //this method is for add 2 score for player when he destroy a planet
    public void AddScore_2(){
        score +=2;
        scoreText.text =""+score;
    }
    //this method is for add 1 score for player when he destroy a planet
    public void AddScore_3(){
        score +=1;
        scoreText.text =""+score;
    }

}
