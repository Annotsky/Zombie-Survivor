using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject thingToFollow;
    [SerializeField] private Vector3 offset;
    
    private void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + offset;
    }
}
