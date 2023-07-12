using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeYourMessengerSelf : MonoBehaviour
{
    public int speed = 10;
    public GameObject scrollview;
    public GameObject panel;
    public bool onetime = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 15f)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            Vector3 newPosition = new Vector3(15f, transform.position.y, transform.position.z);
            transform.position = newPosition;
        }
        if (transform.position.x == 15f)
        {
            if (onetime == false){
                Debug.Log("hi how's life - chichi");
                StartDialogueAlready();
                onetime = true;
            }
        }
    }
    void StartDialogueAlready()
    {
        panel.SetActive(true);
    }
    public void EnableCanvas()
    {
        panel.SetActive(false);
        scrollview.SetActive(true);
    }

    public void DisableCanvas()
    {
        scrollview.SetActive(false);
        SceneManager.LoadScene("TestScene");
    }
}
