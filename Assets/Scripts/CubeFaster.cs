using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeFaster : CubeDefault //INHERITANCE
{
    public override void Start() //POLYMORPHISM
    {
        base.Start();
        force = 0.4f;
        pointValue = 3;
    }
}
