using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBigger : CubeDefault //INHERITANCE
{
    public override void CubeTransform() //POLYMORPHISM
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
}
