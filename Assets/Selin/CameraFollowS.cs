using UnityEngine;

public class CameraFollowS : MonoBehaviour
{
    public Transform target;      // The player or object to follow
    public float smoothSpeed = 5f; // Optional: smooths movement

    private Vector3 offset;

    void Start()
    {
        // Record initial offset (only use Y and Z)
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Only follow X position
        float targetX = Mathf.Lerp(transform.position.x, target.position.x + offset.x, smoothSpeed * Time.deltaTime);

        // Keep Y and Z fixed
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
    }
}
