using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{

    public GameObject prefab;
    public Transform[] attractorPoints;


    private void Start()
    {
        InvokeRepeating("startInstantiatingCubes", 0, .005f);
        //startInstantiatingCubes();
    }

    private void startInstantiatingCubes()
    {
        // need vector 3 for location to instantiate prefab

        var randomIndex = Random.Range(0, 3);
        //Debug.Log(randomIndex);


        var NewVector3AroundAttractorPoint = new Vector3(attractorPoints[randomIndex].position.x + Random.Range(-5.0f, 5.0f),
            attractorPoints[randomIndex].position.y + Random.Range(-5.0f, 5.0f),
            attractorPoints[randomIndex].position.z + Random.Range(-5.0f, 5.0f));

        // tell the cub which attractor point is its parent.
        var cube = Instantiate(prefab, NewVector3AroundAttractorPoint, Quaternion.identity);
        cube.GetComponent<CubeFloat>().attractorPointParent = attractorPoints[randomIndex];
    }



}
