using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private float _speed;


    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }

    public void GetTarget(Vector3 target)
    {
        _target = target;
    }

    public void GetSpeed(float speed)
    {
        _speed = speed;
    }
}
