using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractorLerp : MonoBehaviour
{
    private Vector3 startingPosition;
    private float randomPositionToLerpTo;
    private float randomRangeForMovement;
    private float secondRandomRange;

    // Start is called before the first frame update
    void OnEnable()
    {
        startingPosition = this.transform.position;
        randomRangeForMovement = Random.Range(-15f, 15f);
        secondRandomRange = Random.Range(-1f, 1f);
    }

    private void Update()
    {
        randomPositionToLerpTo = Mathf.Sin(Time.time * randomRangeForMovement/15); // speed
        transform.localPosition = (new Vector3((randomPositionToLerpTo * randomRangeForMovement) * secondRandomRange,
            (randomPositionToLerpTo * randomRangeForMovement) * secondRandomRange,
            (randomPositionToLerpTo * randomRangeForMovement) * secondRandomRange)) + startingPosition; // distance
    }

}
