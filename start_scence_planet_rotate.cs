using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This C# file is used to let the planet in the start scence to rotate;

public class start_scence_planet_rotate : MonoBehaviour
{
    public float rotate;//here I create a variable, which is the angle of rotation of the planet
    //and I can change it in Unity Engine
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //This method is use for let the planet to rotate
    void Update()

    {
        Vector3 angles = this.transform.localEulerAngles;
        angles.y += rotate*Time.deltaTime;
        this.transform.localEulerAngles =angles;
    }
}
