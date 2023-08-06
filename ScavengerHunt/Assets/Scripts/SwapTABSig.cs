using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTABSig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject chattab;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchtoChat()
    {
        Debug.Log("IM ACTIVE NOW YALL :D");
        chattab.SetActive(true);
    }
}
