using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Purpose:
    // Only moves Player character
    // Now does everything related to player, such as entering houses, and enabling panels through touch. 

    public GameObject Map;
    public int once = 0;
    public GameObject EnterMessage;
    public bool really;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); // Works
        if (really == true) // Works
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }


    }

    public int movementspeed = 10;
    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
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

    public void EnableCanvas() // Not Working for whatever reason. 
    {
        if (once == 0)
        {
            Map.SetActive(true);
            once = 1;
            movementspeed = 0;

        }
        else
        {
            Map.SetActive(false);
            once = 0;
            movementspeed = 10;
        }
    }

    void OnTriggerEnter2D(Collider2D col) // works
    {
        if (col.tag == "House")
        {
            EnterMessage.SetActive(true);
            really = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "House")
        {
            EnterMessage.SetActive(false);
            really = false;
        }
    }

}
