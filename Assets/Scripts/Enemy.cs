using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveForward();
    }

    public void MoveForward()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    public void SetParametrs(float speed, Vector3 direction)
    {
        _speed = speed;
        _direction = direction;
    }
}
