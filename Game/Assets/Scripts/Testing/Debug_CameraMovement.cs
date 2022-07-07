using UnityEngine;

public class Debug_CameraMovement : MonoBehaviour
{
    public int Speed = 50;

    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal") * Speed*Time.deltaTime;
        float zAxisValue = Input.GetAxis("Vertical") * Speed* Time.deltaTime;

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y, transform.position.z + zAxisValue);
    }
}