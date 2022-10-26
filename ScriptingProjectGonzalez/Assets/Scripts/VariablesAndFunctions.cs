using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myint = 5;
    
    void Start()
    {
        myint = MultiplyByTwo(myint);
        Debug.Log(myint);
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
    void Update()
    {
        
    }
}
