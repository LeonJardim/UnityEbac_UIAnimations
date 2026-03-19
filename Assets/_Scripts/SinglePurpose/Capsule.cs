using UnityEngine;

public class Capsule : MonoBehaviour
{
    public GameObject capsulePreFab;
    
    public void CreateCapsule()
    {
        var a = Instantiate(capsulePreFab);
        a.transform.position = Vector3.zero;
        Debug.Log("Capsule created");
    }
}
