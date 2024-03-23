using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject player;
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 0, -10);
    }
}
