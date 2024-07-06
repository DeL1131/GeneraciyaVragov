using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void FixedUpdate()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    public void SetParametrs(Vector3 direction)
    {
        _direction = direction;
    }
}
