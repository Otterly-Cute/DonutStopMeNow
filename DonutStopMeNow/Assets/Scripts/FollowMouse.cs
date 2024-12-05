using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // https://discussions.unity.com/t/3d-object-follow-mouse/792952/2
    public Rigidbody rb;
    void Update()
    {
        rb.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    }
}
