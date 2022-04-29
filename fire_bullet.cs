using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this c# file is used to control the fire of the bullet.

public class fire_bullet : MonoBehaviour
{
    public GameObject bullet; //this is the gameobject that shoot by the spaceship
    public Transform fire_position; //This is where the bullet will be fired 
    public Transform cube; //I created this so that the direction of the bullet's launch can change with the movement of the spaceship
    public AudioClip audioSuccess; //Add sound effects to bullet firing
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //In each frame of the game, it is judged whether the left mouse button is pressed, 
        //and if it is pressed, a bullet is fired and a sound effect is played.
        if(Input.GetMouseButtonDown(0)){
            
            fire();
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSuccess);
            
        }
        

       
    }

    // this method is for fire a bullet
    private void fire(){
        //Spawns a bullet where it fires
        GameObject ob1 = Object.Instantiate(bullet,null);
        ob1.transform.position=this.fire_position.position;

        //When the ship rotates, the bullet also rotates
        Vector3 plus = new Vector3(0,90,0);
        ob1.transform.eulerAngles = this.cube.eulerAngles+plus;

        //Here the script of the bullet itself is quoted and its movement speed is set
        BulletLogic sc = ob1.GetComponent<BulletLogic>();
        sc.speed = 0.5f;

    }
}
