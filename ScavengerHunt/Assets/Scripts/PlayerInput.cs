using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TMP_InputField user_inputField;
    public string playername;
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (user_inputField.text == "")
        {
            Debug.Log("welp going w/ chichi:");
            playername = "chichi";
            text.text = "Well, I guess changing my name won't matter too much anyways. I'll stick with ChiChi";

        }
        else
        {
            playername = user_inputField.text.ToString();
            Debug.Log("player name is " + playername);
            text.text = "Good Choice. I love the feel of the name Detective " + playername + ". Now let's go exploring to this crime scene of theirs.";
        }
    }
}
