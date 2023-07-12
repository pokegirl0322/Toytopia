using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject oldpanel;
    public GameObject newpanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DialogueTimeIG()
    {
        oldpanel.SetActive(false);
        newpanel.SetActive(true);
    }


}
