using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//This C# file is used for calling a meteor in player's screen,
// which can improve the aesthetics of the game
public class meteor : MonoBehaviour
{
   public float times1 = 0.2f; //here we define a time,which name is times1, for using in the InvokeReapting method
   public float times2 = 3f;//here we define a time,which name is times2, for using in the InvokeReapting method
    public GameObject Flyposition;//this is the position where the meteor will be created
    public GameObject prefabs; //create a gameobject which is the meteor

    // Start is called before the first frame update
    void Start()

    {
        //here I use a method called "InvokeRePeating",
        //when a player start the game, after times1, the game will call a method called meteorFly
        //and in every times2, the game will call the method "meteorFly"
        InvokeRepeating("meteorFly",times1,times2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this method is for create a meteor
    public void meteorFly(){
        GameObject meteor_1 = Object.Instantiate(prefabs,null);//here I create the meteor
        meteor_1.transform.position = this.Flyposition.transform.position;//and this is used for locate the meteor

   }
}
