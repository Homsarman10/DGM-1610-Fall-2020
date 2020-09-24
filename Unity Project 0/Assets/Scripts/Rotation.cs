using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 rotationVector3;
    private void Update()
    {
        rotationVector3.x = speed * Time.deltaTime;
        rotationVector3.y = speed * Time.deltaTime;
        rotationVector3.z = speed * Time.deltaTime;
        transform.Rotate (rotationVector3);
    }
}
