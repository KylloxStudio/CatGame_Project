using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = mousePos.x;
        if (x > 2.5f) x = 2.5f;
        else if (x < -2.5f) x = -2.5f;
        transform.position = new Vector3(x, transform.position.y);
    }
}
