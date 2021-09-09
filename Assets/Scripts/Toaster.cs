using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.UIElements;
using UnityEngine;
using Random = UnityEngine.Random;

public class Toaster : MonoBehaviour {
    
    /* me trying
    public double[] limit = {-10.0, 10,0};
    private bool left = true;
    public float speed = 3; */
    [SerializeField] GameObject catbread;
    
    private Vector3 directVector = Vector3.left;
    [SerializeField] float speed = 3;

    private float timer = 0;
    [SerializeField] float catdrop = 2;

    [SerializeField] private float[] bounds = {-10, 10};
    
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        /* me trying */
        //Instantiate(catbread);
        /*
        if (transform.position.x <= limit[0])
            left = false;
        if (transform.position.x >= limit[1])
            left = true;
        if (left)
            transform.position += Vector3.left * Time.deltaTime * speed;
        if (!left)
            transform.position += Vector3.right * Time.deltaTime * speed;*/
        Vector3 position = transform.position;
        if (position.x <= bounds[0])
            directVector = Vector3.right;
        if (position.x >= bounds[1])
            directVector = Vector3.left;
        transform.position += directVector * Time.deltaTime * speed;

        timer += Time.deltaTime;
        if (timer >= catdrop) {
            timer -= timer;
            GameObject bread = Instantiate(catbread, position, Quaternion.identity);
            bread.SetActive(true);
        }
    }
}
