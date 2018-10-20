using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    public List<DataBehaviour> behaviours;

    void Update()
    {
        foreach(var i in behaviours)
            i?.Change(transform);
    }
}
