using UnityEngine;
using UnityEngine.UI;

public class HoleManager : MonoBehaviour
{
    private float circleCapacity;
    [SerializeField] private Image circleImg;
    [SerializeField] private Transform holeGameObj;

    private void ProgressBar (int number)
    {
        circleCapacity = 1f / number;
        circleImg.fillAmount += circleCapacity;

        if (circleImg.fillAmount.Equals(1f))
        {
            holeGameObj.localScale += new Vector3(x: 0.3f, y: 0f, z: 0.3f);

            circleImg.fillAmount = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collectable"))
        {
            ProgressBar(number: 20);

            other.gameObject.SetActive(false);
        }
    }

}
