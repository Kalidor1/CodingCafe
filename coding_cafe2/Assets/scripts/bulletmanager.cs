using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmanager : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public float time;
    void Awake()
    {
        Destroy(this.gameObject, time);
    }
}
