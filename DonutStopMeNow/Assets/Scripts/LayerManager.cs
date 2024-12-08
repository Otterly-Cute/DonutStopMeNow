using UnityEngine;

public class LayerManager : MonoBehaviour
{
    [SerializeField] private string[] layers = { "Default", "noColl" };


    private void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other, 1); // noColl layer
    }

    private void OnTriggerExit(Collider other)
    {
        ChangeLayer(other, 0); // Default layer
        
        other.transform.position += Vector3.up * 0.01f;
    }

    private void OnTriggerStay(Collider other)
    {
        other.transform.position += Vector3.down * 0.01f;
    }

    private void ChangeLayer(Collider other, int index)
    {
        other.gameObject.layer = LayerMask.NameToLayer(layers[index]);
    }


}
