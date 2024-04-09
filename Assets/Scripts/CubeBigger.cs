using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBigger : CubeDefault
{
    public override void CubeTransform()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
}
