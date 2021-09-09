using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alf : MonoBehaviour {
    private Vector3 direction = Vector3.right;
    [SerializeField] private float speed = 5;

    [SerializeField] private float[] bounds = {-10, 10};
    [SerializeField] private AudioSource one;
    [SerializeField] private AudioSource two;
    
    private int catscollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            one.Play();
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            two.Play();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { 
            direction = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            direction = Vector3.right;
        }
        if (transform.position.x <= bounds[0])
            direction = Vector3.right;
        if (transform.position.x >= bounds[1])
            direction = Vector3.left;
        transform.position += direction * speed * Time.deltaTime;
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Cute")) {
            catscollected++;
            Destroy(other.gameObject);
            
        }
    }
}
