using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public GameObject followTarget;
    public float initialOffset;
    public float initialXPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialOffset = transform.position.x - followTarget.transform.position.x;
        initialXPosition = followTarget.transform.position.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = followTarget.transform.position.x;
        x = -transform.position.z * (x - initialXPosition) + initialOffset + x;
        transform.position = new Vector3( x, transform.position.y, transform.position.z);
    }
}
