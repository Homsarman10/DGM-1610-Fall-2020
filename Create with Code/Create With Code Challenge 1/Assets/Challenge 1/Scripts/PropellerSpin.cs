
using UnityEngine;

public class PropellerSpin : MonoBehaviour

{
    public float rotateSpeed = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
}
