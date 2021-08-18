using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBasedOnDistanceFromThing : MonoBehaviour
{
    public GameObject Thing;

    void Update()
    {
        var distFromThing = Vector3.Distance(this.transform.position, Thing.transform.position);

        transform.rotation = Quaternion.Euler(distFromThing * 10, 0f, 0f);
    }
}
