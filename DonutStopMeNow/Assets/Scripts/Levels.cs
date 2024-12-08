using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    // Use singletons to access this class from other classes easily
    #region Singleton class: Level 

    public static Levels Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    public int objectsInScene;
    public int totalObjects;
    Transform current;
    

    [SerializeField] Transform lvlOne, lvlTwo;

    void Start()
    {
        current = lvlOne;
        CountObjects();
    }

    public void NextLevel()
    {
        current = lvlTwo;
    }

    public void CountObjects()
    {
        totalObjects = current.childCount;
        objectsInScene = totalObjects;
    }
}
