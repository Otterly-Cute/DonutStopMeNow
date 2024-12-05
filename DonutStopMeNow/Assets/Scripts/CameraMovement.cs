using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=ONlMEZs9Rgw move
    //https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/ camera zoom
    //https://www.youtube.com/watch?v=H7pjj1K91HE drag and drop

    //public InputActionReference move;
    public InputActionReference zoom;

    //private Rigidbody rb;
    //private Vector3 moveDirection;
    //public float moveSpeed;

    private Camera cam;
    public float zoomSpeed;
    public float minZoom = 30;
    public float maxZoom = 100;

    private void Awake()
    {
        //rb = GetComponent<Rigidbody>();
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        //moveDirection = move.action.ReadValue<Vector3>();

        if (zoom.action.ReadValue<float>() > 0)
        {
            ZoomCamera(minZoom);
        }
        else if (zoom.action.ReadValue<float>() < 0)
        {
            ZoomCamera(maxZoom);
        }
    }

    private void FixedUpdate()
    {
       // rb.linearVelocity = new Vector3(x: moveDirection.x * moveSpeed, y: moveDirection.y * 0, z: moveDirection.z * moveSpeed).normalized;
    }


    /// <summary>
    /// https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/
    /// </summary>
    /// <param name="target"></param>
    void ZoomCamera(float target)
    {
        cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, zoomSpeed * Time.deltaTime);
    }
}
