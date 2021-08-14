using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newFlaot : MonoBehaviour
{
    public float _speed;
    private bool start = false;
    private float timeSinceStarted;
    private float randomFloat_1;
    private bool firstTime = true;

    private void Start()
    {
        StartCoroutine(turnStartToTrue());
        randomFloat_1 = Random.Range(-11f, 11f);

        Color SHoPGreen = new Color32(30, 30, 30, 255);
        this.gameObject.GetComponent<MeshRenderer>().material.color = SHoPGreen;

        _speed = Random.Range(0f, 3f);

    }

    void Update()
    {
        if (start)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;

            float newY = Mathf.Sin(((Time.time - timeSinceStarted) * _speed) -10);
            this.transform.localPosition = new Vector3(this.transform.position.x, (newY * randomFloat_1), this.transform.position.z);

            if (firstTime)
            {
                StartCoroutine(switchColor());
                firstTime = false;
            }
            
        }

    }

    IEnumerator turnStartToTrue()
    {
        var randomRange = Random.Range(0.1f, 90f);
        yield return new WaitForSeconds(randomRange);
        Debug.Log("randomRange: " + randomRange);
        timeSinceStarted = Time.timeSinceLevelLoad;
        start = true;
    }

    IEnumerator switchColor()
    {
        yield return new WaitForSeconds(.6f);
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color32(145, 145, 145, 255);

    }
}
