using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0f, 16f, -11f);

    // più è alto, più la camera è morbida
    [SerializeField] private float smoothTime = 0.15f;

    // stato interno
    private Vector3 velocity;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desired = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, desired, ref velocity, smoothTime);

        Vector3 fromCamToPlayer = target.position - transform.position;
        Quaternion desiredRotation = Quaternion.LookRotation(fromCamToPlayer);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f * Time.deltaTime);
    }
}
