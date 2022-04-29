using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_2_star_move : MonoBehaviour
{

    public GameObject level3; //create a gameobject which is a prefab

    // Start is called before the first frame update
    void Start()
    {
        float a = Random.Range(100f, 200f);//a is a randomly generated force of a magnitude
        float b = Random.Range(-150f, 150f);//b is a randomly generated force of a magnitude
        //Here we add a force to the planet to make it move on its own
        GetComponent<Rigidbody>().AddForce(new Vector3(a, 0, b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this method is used for collision detection, when a bullet collide with this planet
    // it will destroy itself and create 2 new planet at the place where it die
    //then we will add some score for the player
    private void OnTriggerEnter(Collider other){
        if(other.name.Equals("子弹(Clone)")){
        GameObject star2 = Instantiate(level3,null);
        star2.transform.position = this.transform.position;
        GameObject star3 = Instantiate(level3,null);
        star3.transform.position = this.transform.position;
        GameObject main =GameObject.Find("main_control");
        main.SendMessage("AddScore_2");
        Object.Destroy(this.gameObject);
        
        }}
}
