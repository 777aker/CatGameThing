using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class catBread : MonoBehaviour {
    private Rigidbody2D body;
    [SerializeField] float force = 300;
    [SerializeField] Transform alf;
    [SerializeField] float turnSpeed;
    
    // Start is called before the first frame update
    void Start() {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(Vector2.up * force);
        body.AddTorque(Random.Range(-20, 20));
        /*
        if (Random.Range(1, 2) == 1) {
            //body.AddForce(Vector2.left * Random.Range(50, 100));
            
        } else {
            //body.AddForce(Vector2.right * Random.Range(300, 400));
        }*/
    }

    private void FixedUpdate() {
        Vector2 forceDirection = alf.position - transform.position;
        //forceDirection += Vector2.down;
        body.AddForce(forceDirection * Time.fixedDeltaTime * turnSpeed);
    }

    // Update is called once per frame
    void Update() {
        //transform.position += Vector3.down * Time.deltaTime;
    }
}
