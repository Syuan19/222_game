using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    public float speed; //create the variable for the speed of the bullet
    public GameObject explosion; //create a gameobject, which is used to show a explosion effect 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed, Space.Self);//The code to make the bullet run, which means a bullet will run through the z axis.
    }

    //This method is used to detect collisions
    private void OnTriggerEnter(Collider other){
        
        Object.Destroy(this.gameObject); //when bullet collide with something, it will destroy itself, like the wall of the planet.
        GameObject effect = Instantiate(explosion,null); //create the gameobject we say at first, which is a prefab for showing the explosion effect.
        effect.transform.position=this.transform.position; //the explosion effect will show at the place where the bullet collide with other.
        

    }
    
}
