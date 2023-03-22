using UnityEngine;

public class ObjectToMask : MonoBehaviour
{
    private int queueValue = 3002;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var material in GetComponentsInChildren<MeshRenderer>())
        {
            GetComponent<MeshRenderer>().material.renderQueue = queueValue;
            queueValue++;
        }
        
    }
}
