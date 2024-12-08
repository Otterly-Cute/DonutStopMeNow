using UnityEngine;
using UnityEngine.AI;

public class HoleMovement : MonoBehaviour
{
    // Use singletons to access this class from other classes easily
    #region Singleton class: HoleMovement 

    public static HoleMovement Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    //https://www.youtube.com/watch?v=p2-uQEG9-3Y move without unity input system

    float speed;

    private void Start()
    {
        UpdateSpeed();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.position += Vector3.forward * Time.deltaTime * speed; }

        if (Input.GetKey(KeyCode.S)) { transform.position += Vector3.back * Time.deltaTime * speed; }

        if (Input.GetKey(KeyCode.A)) { transform.position += Vector3.left * Time.deltaTime * speed; }

        if (Input.GetKey(KeyCode.D)) { transform.position += Vector3.right * Time.deltaTime * speed; }
    }

    public void UpdateSpeed()
    {
        speed = GetComponent<NavMeshAgent>().speed;
    }
}
