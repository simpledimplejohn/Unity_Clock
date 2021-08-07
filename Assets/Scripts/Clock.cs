using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //has date time access

public class Clock : MonoBehaviour //means its attached to an object changes the type declaration to extend that type
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f; 

    [SerializeField] //attribute attached to the variable that allows the scene to access the data, could be public but its a unity thing
    Transform hoursPivot; //variable that can hold transform data

    [SerializeField]
    Transform minsPivot;

    [SerializeField]
    Transform secsPivot;

    private void Update() //method that runs when the program starts
    {
        DateTime time = DateTime.Now;

        hoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour); //a way of rotating 3d objects in 3d space (x,y,z)
        // 30deg around the z axis = 1 hour
        //hoursPivot.localRotation is called a struct which is like a class
        minsPivot.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        secsPivot.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);


    }


}
