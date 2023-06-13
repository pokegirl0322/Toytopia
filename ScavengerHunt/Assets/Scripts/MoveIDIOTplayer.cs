using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIDIOTplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public int movementspeed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A)) {
            transform.Translate (Vector3.left * movementspeed * Time.deltaTime); 
        }
        if(Input.GetKey (KeyCode.D)) {
            transform.Translate (Vector3. right *   movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * movementspeed * Time.deltaTime);
        }
    }
}
