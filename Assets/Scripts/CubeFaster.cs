using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeFaster : CubeDefault
{
    public override void Start()
    {
        base.Start();
        force = 2;
    }
}
