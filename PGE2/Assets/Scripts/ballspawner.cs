using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawner : MonoBehaviour
{
    public Transform basketball;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            SpawnBall();
        }
       
    }
    private void SpawnBall()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePosition);
        Instantiate(basketball, mousePosition, Quaternion.identity);

    }
}
