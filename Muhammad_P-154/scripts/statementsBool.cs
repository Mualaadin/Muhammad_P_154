using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statementsBool : MonoBehaviour
{
    public bool student;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // cheking for true
      //  if (student) //-if (student == true)
     //   {
     //       print("passed");
      //  }
      //  else
     //   {
       //     print("try again");
       // }

        // cheking for false
        if (!student) //-if (student == true)
        {
            print("try again");
        }
        else
        {
            print("passed");
        }


    }


}
