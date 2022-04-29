using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;







//this C# file is the main control file of the level_1 of the game,
//and this is similar to the main_logie_2 script
//and the comments is also the same, you can see the comments from the script
//which name is main_logic_2 




public class MainLogic : MonoBehaviour
{
    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreText.text.Equals("51")){
            SceneManager.LoadScene(4);
        }
        
    }
    public void AddScore_1(){
        score +=1;
        scoreText.text =""+score;
    }

    public void AddScore_2(){
        score +=2;
        scoreText.text =""+score;
    }

    public void AddScore_3(){
        score +=3;
        scoreText.text =""+score;
    }


}
