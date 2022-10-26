using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTempature = 85.0f;
    float hotlimitTempature = 70.0f;
    float coldlimitTempature = 40.0f;


    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempatureTest();

        coffeeTempature -= Time.deltaTime * 5f;
    }

    
    void TempatureTest ()
    {
        // If the coffee's tempature is greater than the hottest drinking tempature...
        if(coffeeTempature > hotlimitTempature)
        {
            //... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee's tempature is less than the coldest drinking tempature...
        else if(coffeeTempature < coldlimitTempature)
        {
            //... do this
            print("Coffee is too cold.");
        }
        // If it is neither of these...
        else
        {
            //... do this
            print("Coffee is just right.");
        }
    }
}
