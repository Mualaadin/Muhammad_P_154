using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statementsString : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (name == "Muhammad")
        {
            print("You are Muhammad");
        }
        else
        {
            print("You are not Muhammad");
        }
    }
}
