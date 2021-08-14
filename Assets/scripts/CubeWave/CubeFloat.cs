using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour
{
    // speed and height determined from distance to attractorpoints

    public Transform attractorPointParent;

    private float _speed;
    private float _height;
    private float _distanceFromAttractorParent;
    

    private Vector3 startingPosition;

    private void OnEnable()
    {
        float newY = Mathf.Sin(Time.time * _speed);
        startingPosition = this.transform.position;
        transform.localPosition = (new Vector3(0, newY, 0) * _height) + startingPosition;
        

        // wait for just a split second beforre running this
        StartCoroutine(setVariables());

        StartCoroutine(startTimerThenDestroyYourself());
    }

    IEnumerator setVariables()
    {
        yield return new WaitForSeconds(.1f);

        
        _distanceFromAttractorParent = Vector3.Distance(this.transform.position, attractorPointParent.position);
        //Debug.Log("dist: " + _distanceFromAttractorParent);

        //ler this be determined by distance from attractorr point
        _speed = _distanceFromAttractorParent/5;
        _height = _distanceFromAttractorParent *2;

        transform.localScale = new Vector3(_distanceFromAttractorParent/5, _distanceFromAttractorParent/5, _distanceFromAttractorParent/5) ;
        //var alpha = transform.GetComponent<MeshRenderer>().material.color.a;
        //alpha = _distanceFromAttractorParent / 1;

    }

    IEnumerator startTimerThenDestroyYourself()
    {
        yield return new WaitForSeconds(5f);

        Destroy(this.gameObject);
    }

    // constant movement
    void Update()
    {
        _distanceFromAttractorParent = Vector3.Distance(this.transform.position, attractorPointParent.position);
        float newY = Mathf.Sin(Time.time * _speed);
        transform.localPosition = (new Vector3(0, newY, 0) * _height) + startingPosition;
        transform.localScale = new Vector3(_distanceFromAttractorParent /7, _distanceFromAttractorParent / 7, _distanceFromAttractorParent / 7);
        transform.Rotate((_distanceFromAttractorParent * 5) * Time.deltaTime, (_distanceFromAttractorParent * 5) * Time.deltaTime, (_distanceFromAttractorParent * 5) * Time.deltaTime);


    }
}
