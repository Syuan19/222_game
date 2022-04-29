using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_2_star_move1 : MonoBehaviour
{
    public int HP = 3;//Set the planet's HP to 3
    public GameObject level2;//create the gameobject that is a prefab
    // Start is called before the first frame update
    void Start()
    {
        float a = Random.Range(250f, 350f);//a is a randomly generated force of a magnitude
        float b = Random.Range(-250f, 350f);//b is a randomly generated force of a magnitude
        //Here we add a force to the planet to make it move on its own
        GetComponent<Rigidbody>().AddForce(new Vector3(a, 0, b));
        
    }

    // Update is called once per frame
    void Update()
    {
        //n each frame of the game, it is judged whether the HP of a planet has down to one
        //if the hp of a planet is 0, then it will destroy itself
        //and create 3 planets
        //then add some score for the player 
        if(HP == 0){
        GameObject star2 = Instantiate(level2,null);
        star2.transform.position = this.transform.position;
        GameObject star3 = Instantiate(level2,null);
        star3.transform.position = this.transform.position;
        GameObject star4 = Instantiate(level2,null);
        star4.transform.position = this.transform.position;
        GameObject main =GameObject.Find("main_control");
        main.SendMessage("AddScore_1");
                Object.Destroy(this.gameObject);

        }
        
    }
    //this method is for collision detection, when the planet collide with a bullet,
    //the hp of it will minus 1
    private void OnTriggerEnter(Collider other){
        if(other.name.Equals("子弹(Clone)")){

            HP -= 1;
        
        
        }}
}
