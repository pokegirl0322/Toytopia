using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DontMovePastBorder : MonoBehaviour
{
    // Start is called before the first frame update
    public float xpos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xpos = Mathf.Clamp(transform.position.x, -6, 14);
        transform.position = new Vector3(xpos, transform.position.y, transform.position.z);
    }
}
