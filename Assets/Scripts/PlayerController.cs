using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float speed = 1;
    public Rigidbody2D playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)) {
        playerRb.AddForce(Vector3.up * 100, ForceMode2D.Impulse);
      }
      if (Input.GetKey (KeyCode.A)) {
          transform.Translate(Vector3.left * Time.deltaTime * speed, Space.Self);
          transform.localRotation = Quaternion.Euler(0, 0, 0);
      }
      if (Input.GetKey (KeyCode.D)) {
          transform.Translate(Vector3.left * Time.deltaTime * speed, Space.Self);
          transform.localRotation = Quaternion.Euler(0, 180, 0);
      }
    }

    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Enemy") {
            Debug.Log("Collided with imaginary enemy that totally doesnt exist. ");
        }
    }
}
