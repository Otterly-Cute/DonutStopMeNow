using UnityEngine;
using UnityEngine.UI;
using Unity.Cinemachine;
using UnityEngine.AI;


public class HoleManager : MonoBehaviour
{
    [SerializeField] CinemachineCamera vcam;

    public CinemachineFollow follow;
    public NavMeshAgent agent;
    public float speed;
    [SerializeField] ParticleSystem pink,purple,blue,green,orange,bold;
    
    private void Start()
    {
        follow = vcam.GetComponent<CinemachineFollow>();
        agent = gameObject.GetComponentInParent<NavMeshAgent>();
    }

   
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;

        if (other.CompareTag("collectable"))
        {
             Levels.Instance.objectsInScene--;
             UIManager.Instance.UpdateLevelProgress();

             Destroy(other.gameObject);

            // Check if win
            if (Levels.Instance.objectsInScene == 0)
            {
                pink.Play();
                purple.Play();
                blue.Play();
                green.Play();
                orange.Play();
                bold.Play();

                Levels.Instance.NextLevel();
                Levels.Instance.CountObjects();
                UIManager.Instance.UpdateLevelProgress();

                gameObject.transform.parent.localScale = new Vector3(2,1,2);

                agent.speed = speed;
                HoleMovement.Instance.UpdateSpeed();

                follow.FollowOffset = new (0, 10, -1);

               
            }
            
        }
    }

}
