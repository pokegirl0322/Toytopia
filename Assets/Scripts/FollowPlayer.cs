using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float xpos;
    public int movecam = 0;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate ()
    {
        transform.position = player.transform.position+offset;
    }
    void Update()
    {

    }
}
