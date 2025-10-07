using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 15;

    void Update()
    {
        if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
        } else if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(new Vector3(0, 0, -rotateSpeed * Time.deltaTime));
        }
    }
}
