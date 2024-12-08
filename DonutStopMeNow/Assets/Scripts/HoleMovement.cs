using UnityEngine;
using UnityEngine.InputSystem;

public class HoleMovement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=p2-uQEG9-3Y move without unity input system
    //https://www.youtube.com/watch?v=ONlMEZs9Rgw move
    //https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/ camera zoom
    //https://www.youtube.com/watch?v=H7pjj1K91HE drag and drop

    //public InputActionReference move;
    //public InputActionReference zoom;

    //private Rigidbody rb;
    //private Vector3 moveDirection;
    public float moveSpeed;

    //private Camera cam;
    //public float zoomSpeed;
    //public float minZoom = 30;
    //public float maxZoom = 100;

    private void Awake()
    {
        //rb = GetComponent<Rigidbody>();
        //cam = GetComponent<Camera>();
    }

    private void Update()
    {
        //moveDirection = move.action.ReadValue<Vector3>();


        if (Input.GetKey(KeyCode.W)) { transform.position += Vector3.forward * Time.deltaTime * moveSpeed; }

        if (Input.GetKey(KeyCode.S)) { transform.position += Vector3.back * Time.deltaTime * moveSpeed; }

        if (Input.GetKey(KeyCode.A)) { transform.position += Vector3.left * Time.deltaTime * moveSpeed; }

        if (Input.GetKey(KeyCode.D)) { transform.position += Vector3.right * Time.deltaTime * moveSpeed; }

        //if (zoom.action.ReadValue<float>() > 0)
        //{
        //    ZoomCamera(minZoom);
        //}
        //else if (zoom.action.ReadValue<float>() < 0)
        //{
        //    ZoomCamera(maxZoom);
        //}
    }

    //private void FixedUpdate()
    //{
    //    transform.position += new Vector3(x: moveDirection.x * Time.deltaTime * moveSpeed, y: moveDirection.y * 0, z: moveDirection.z * Time.deltaTime * moveSpeed).normalized;
    //}


    /// <summary>
    /// https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/
    /// </summary>
    /// <param name="target"></param>
    //void ZoomCamera(float target)
    //{
    //    cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, zoomSpeed * Time.deltaTime);
    //}
}
