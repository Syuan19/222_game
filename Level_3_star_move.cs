using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_3_star_move : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        float a = Random.Range(400f, 500f);//a is a randomly generated force of a magnitude
        float b = Random.Range(-250f, 500f);//b is a randomly generated force of a magnitude
        //Here we add a force to the planet to make it move on its own
        GetComponent<Rigidbody>().AddForce(new Vector3(a, 0, b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This method is for collision detection
    //when a bullet collide with it, the planet will destroy itself
    //and then add some score for the player
     private void OnTriggerEnter(Collider other){
        if(other.name.Equals("子弹(Clone)")){


        GameObject main =GameObject.Find("main_control");
        main.SendMessage("AddScore_3");
        Object.Destroy(this.gameObject);
        
        }}
}
