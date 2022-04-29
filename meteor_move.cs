using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This C# file is used for let the meteor move
public class meteor_move : MonoBehaviour
{
    //here I create the speed of the meteor
    public float speed1 = -0.2f;
    public float speed2 = -0.2f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //in each frame of the game, the meteor will follow the speed I gave to move in x and y axis;
        this.transform.Translate(speed1,speed2,0,Space.World);
    }
}
