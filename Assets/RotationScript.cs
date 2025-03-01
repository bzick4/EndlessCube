using System.Collections;
using UnityEngine;

public class RotationScript : MonoBehaviour
{

    public float rotationSpeed = 180f; // Скорость поворота (градусы в секунду)
    public KeyCode RightRotateYKey = KeyCode.RightArrow;
     public KeyCode LeftRotateYKey = KeyCode.LeftArrow;

public KeyCode UpRotateXKey = KeyCode.UpArrow;
public KeyCode DownRotateXKey = KeyCode.DownArrow;



    void Update()
    {
        if (Input.GetKey(RightRotateYKey) )
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(LeftRotateYKey))
        {
            transform.Rotate(Vector3.up * rotationSpeed * -Time.deltaTime);
        }

        if (Input.GetKey(UpRotateXKey) )
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(DownRotateXKey) )
        {
            transform.Rotate(Vector3.right * rotationSpeed * -Time.deltaTime);
        }
    }

}
