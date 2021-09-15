using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{
    float spaceBetweenLines = 0.2f;

    void Start()
    {

    }

    void Update()
    {
        //Clear background
        Background(240, 150, 178);

        //Draw our scan lines
        for (int i = 0; i < 10; i++)
        {

            if (i % 3 == 0)
            {
                Stroke(128, 128, 128);
            }
            else
            {
                Stroke(0, 0, 0);
            }

            Line(0, 10 - i, i, 0);

        }
    }
}
