using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy[] _enemys;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _speedEnemy;

    private Transform[] _targets;

    private void Start()
    {
        InvokeRepeating(nameof(CreateEnemy), 0.0f, _timeSpawn);
    }

    private void CreateEnemy()
    {
        enemy = _enemys[Random.Range(0, _enemys.Length)];
        Instantiate(enemy, _points[Random.Range(0, _points.Length)].transform.position, Quaternion.identity);
        var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        enemy.GetSpeed(_speedEnemy);
        enemy.GetTarget(position);
    }
}
    