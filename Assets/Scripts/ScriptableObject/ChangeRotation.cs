using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviour/ChangeRotation")]
public class ChangeRotation : DataBehaviour
{
    public float speed = 1; 

    public override void Change(Transform _obj)
    {
        _obj.Rotate(Vector3.one * speed);
    }
}
