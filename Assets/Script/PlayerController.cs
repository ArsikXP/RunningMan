using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private int speed = 20;
    public float horzontal;
    public float vertical;
    public bool gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horzontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * Time.deltaTime * speed * horzontal);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        
    }
}
