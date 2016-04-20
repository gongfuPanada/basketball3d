using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{
    public Rigidbody prefab;
    public float speed = 10.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            var ball = (Rigidbody) Instantiate(prefab, transform.position, transform.rotation);
            ball.velocity = (transform.forward + transform.up * 0.8f) * speed;
        }
    }



}
