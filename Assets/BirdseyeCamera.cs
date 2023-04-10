using UnityEngine;

public class BirdseyeCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _height = 10f;
    [SerializeField] private float _distance = 10f;
    [SerializeField] private float _angle = 30f;

    private void Update()
    {
        // Calculate the camera's position based on the target's position, height, distance, and angle
        Vector3 targetPosition = _target.position + Vector3.up * _height;
        Vector3 cameraPosition = targetPosition - Quaternion.Euler(_angle, 0, 0) * Vector3.forward * _distance;

        // Set the camera's position and rotation to the calculated values
        transform.position = cameraPosition;
        transform.rotation = Quaternion.Euler(_angle, 0, 0);
    }

    public void SetUpCamera(Transform target, float height, float distance, float angle)
    {
        _target = target;
        _height = height;
        _distance = distance;
        _angle = angle;
    }
}