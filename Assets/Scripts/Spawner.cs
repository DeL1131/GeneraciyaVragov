
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy[] _enemys;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _speedEnemy;

    private Enemy _enemy;
    private Transform[] _targets;

    private void Start()
    {
        InvokeRepeating(nameof(CreateEnemy), 0.0f, _timeSpawn);
    }

    private void CreateEnemy()
    {
        _enemy = _enemys[Random.Range(0, _enemys.Length)];
        Instantiate(_enemy, _points[Random.Range(0, _points.Length)].transform.position, Quaternion.identity);
        var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        _enemy.GetSpeed(_speedEnemy);
        _enemy.GetTarget(position);
    }
}
    