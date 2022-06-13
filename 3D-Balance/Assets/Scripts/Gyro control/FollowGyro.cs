
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField]
    private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    private void Start()
    {
        GyroManager.Instance.EnableGyro();
    }

    private void FixedUpdate()
    {
        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;
    }
   /* public Rigidbody _rigidbody;
    private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);

    void Start()
    {
        GyroManager.Instance.EnableGyro();
        //Fetch the Rigidbody from the GameObject with this script attached
        _rigidbody = GetComponent<Rigidbody>();

        
    }

    void FixedUpdate()
    {
        transform. = GyroManager.Instance.GetGyroRotation() * baseRotation;
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
    }*/



}
