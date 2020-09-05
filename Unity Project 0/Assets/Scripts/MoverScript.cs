using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 3f;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x:hInput,y:vInput,z:0);
    }

    public void Up()
    {
        transform.Translate(x:0,y:speed,z:0);
    }

    public void Down()
    {
        transform.Translate(x:0,y:-speed,z:0);
    }
}
