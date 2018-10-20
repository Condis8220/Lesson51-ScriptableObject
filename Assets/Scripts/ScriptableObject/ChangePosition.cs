using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviour/ChangePosition")]
public class ChangePosition : DataBehaviour
{
    public float amplitude = 1;

    public override void Change(Transform _obj)
    {
        _obj.position = Vector3.right * Mathf.Sin(Time.time) * amplitude;
    }
}
