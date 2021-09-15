using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{
    float numberOfLines = 20;

    void Start()
    {

    }

    void Update()
    {
        //Clear background
        Background(240, 150, 178);

        //Draw our scan lines
        for (int i = 0; i <= numberOfLines; i++)//Index = 0 i start, loopen kollar om index �r under h�jden p� sk�rmen, loopen l�gger +1 p� index
        {

            float y1 = Height - i * Height/numberOfLines;
            float x2 = i * Width/numberOfLines;
           
            if (i % 3 == 0)
            {
                Stroke(255, 255, 255);
            }
            else
            {
                Stroke(35, 135, 208);
            }

            Line(0, y1, x2, 0);//F�rsta X-koordinaten = 0, f�rsta y-koordinaten �r h�jden p� sk�rmen - index, andra x = index, andra y = 0

        }
    }
}