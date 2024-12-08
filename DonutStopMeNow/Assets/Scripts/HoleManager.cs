using UnityEngine;
using UnityEngine.UI;



public class HoleManager : MonoBehaviour
{
    //[SerializeField] CinemachineVirtualCamera vcam;
    [SerializeField] ParticleSystem pink,purple,blue,green,orange,bold;
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

                
                // No more objects to collect
                //UIManager.Instance.ShowLevelCompletedUI();

                //Invoke("NextLevel", 2f);
            }
            
        }
    }

    //void NextLevel()
    //{
    //    Levels.Instance.LoadNextLevel();
    //}
}
