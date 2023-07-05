using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Generalness : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject image;
    public int once;
    public GameObject message1;
    public bool really;
    // Update is called once per frame
    void Update()
    {
        if (really == true)
        {
            if (Input.GetKeyDown(KeyCode.E)){
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    public void EnableCanvas()
    {
        if (once == 0)
        {
            image.SetActive(true);
            once = 1;
            GetComponent<MoveIDIOTplayer>().enabled = false;

        }
        else
        {
            image.SetActive(false);
            once = 0;
            GetComponent<MoveIDIOTplayer>().enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "House")
        {
            message1.SetActive(true);
            really = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "House")
        {
            message1.SetActive(false);
            really = false;
        }
    }
}
