using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float moveSpeed = 10f;
    private float minZ = -17.5f;
    private float maxZ = -4.45f;
    public float scrollSpeed = 10f;
    private float minY = 5f;   // Minimum zoom distance
    private float maxY = 20f;  // Maximum zoom distance

    void Update()
    {
        // Move camera with keyboard input
        float moveZ = Input.GetAxis("Vertical");
        Vector3 currentPosition = transform.position;
        currentPosition.z += moveZ * moveSpeed * Time.deltaTime;
        currentPosition.z = Mathf.Clamp(currentPosition.z, minZ, maxZ);

        // Zoom camera with mouse scroll wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            currentPosition.y -= scroll * scrollSpeed * 1000 * Time.deltaTime;
            currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        }

        transform.position = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);
    }
}
