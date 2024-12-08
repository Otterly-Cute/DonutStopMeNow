using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening; //animation
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Use singletons to access this class from other classes easily
    #region Singleton class: UI_Manager 

    public static UIManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    [Header("Level Progress UI")]
    [SerializeField] int sceneOffset;
    [SerializeField] TMP_Text nextLevelText;
    [SerializeField] TMP_Text currentLevelText;
    [SerializeField] Image progressFillImage;

    [Space]
    [SerializeField] TMP_Text levelCompletedText;

    void Start()
    {
        progressFillImage.fillAmount = 0f;
        //SetLevelProgressText();
    }

    //void SetLevelProgressText()
    //{
    //    int level = SceneManager.GetActiveScene().buildIndex + sceneOffset;
    //    currentLevelText.text = level.ToString();
    //    nextLevelText.text = (level + 1).ToString();
    //}

    public void UpdateLevelProgress()
    {
        float val = 1f - ((float)Levels.Instance.objectsInScene / Levels.Instance.totalObjects);   //remainingObject/totalObjects will give us a value between 0 & 1, subtract it from 1 to flip it
        progressFillImage.DOFillAmount(val, .4f);  //val interpolation (0.4 seconds)
    }


    public void ShowLevelCompletedUI()
    {
        levelCompletedText.DOFade(1f, .6f).From(0f); //fade in (alpha 0 => 1) 0.6 seconds
    }
}
