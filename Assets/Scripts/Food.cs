using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0.1f, 0f);
        if (transform.position.y > 7.5f)
        {
            Destroy(gameObject);
        }
    }
}
