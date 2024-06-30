using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Quaternion _rotate;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        transform.rotation = _rotate;
    }

    private void FixedUpdate()
    {
        MoveForward();
    }

    public void MoveForward()
    {
        _rigidbody.MovePosition(_rigidbody.position + transform.forward * 1f * Time.deltaTime);
    }

    public void SetParametrs(float speed, Quaternion rotate)
    {
        _speed = speed;
        _rotate = rotate;
    }
}
