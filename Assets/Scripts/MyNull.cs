using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNull : MonoBehaviour
{
    string firstName="Mohamed";
    string lastName= null;
    int ?meaningOfLife = null;
    // Start is called before the first frame update
    void Start()
    {
        int trueNumber = meaningOfLife ?? 42;
        Debug.Log(trueNumber);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
