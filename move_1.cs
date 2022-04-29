using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class move_1 : MonoBehaviour
{
    public float rotate = 5; //The angle of each turn of the spacecraft
    public float start_moveSpeed = 0; // start speed of the space ship
    public float maxMoveSpeed = 3f;//Limit the maximum speed at which the ship can run
    
    

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        // this "if" is used to detect whether a player has press W or not
        //if the player press W, then the move speed will add 0.005f
        //and stop when the speed of the spaceship reached the maxMovespeed I gave
        if(Input.GetKey(KeyCode.W)){
            if(start_moveSpeed<maxMoveSpeed){
                start_moveSpeed+=0.005f;
                if(start_moveSpeed>maxMoveSpeed){
                    start_moveSpeed=maxMoveSpeed;
                }
            }
        }        
        // this "if" is used to detect whether a player has press S or not
        //if the player press S, then the move speed will decrease 0.02f
        //and stop when the speed of the spaceship reached 0
        if(Input.GetKey(KeyCode.S)){
            start_moveSpeed -=0.02f;
            if(start_moveSpeed<0){
                start_moveSpeed=0;
            }
        }
       
        float dx = 0;
        float dy = 0;
        dx =start_moveSpeed;
        //when player press W the spaceship will speed up and go straight
        if(Input.GetKey(KeyCode.W)){
            dx = start_moveSpeed;
        }
         //when player press A the spaceship will make Anticlockwise rotation
        this.transform.Translate(dx,0,0,Space.Self);
        if(Input.GetKey(KeyCode.A)){
            dy=-rotate;
        }
         //when player press A the spaceship will make clockwise rotation
        if(Input.GetKey(KeyCode.D)){
            dy=rotate;
        }
        this.transform.Rotate(0,dy,0,Space.Self);


        
    }

    
    
    //this method is for collision detection
    //when the spaceship collide with something
    //it will destroy itself
    //and then will lead the player to "lose scene"
    private void OnTriggerEnter(Collider other){
        Object.Destroy(this.gameObject);
        SceneManager.LoadScene(2);

    }

    
}
