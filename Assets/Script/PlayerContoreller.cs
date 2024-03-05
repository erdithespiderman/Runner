using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoreller : MonoBehaviour
{
    public int speed = 10;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        //transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime);
    }
}
