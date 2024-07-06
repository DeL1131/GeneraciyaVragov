using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy[] _enemys;

    [Tooltip("Интервал спавна противников")]
    [SerializeField] private float _timeSpawn;

    private bool _isWork = true;
    private Enemy _enemy;

    private float _minSpawnRange = -1;
    private float _maxSpawnRange = 1;


    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_timeSpawn);

        while (_isWork)
        {
            yield return waitForSeconds;
            _enemy = _enemys[Random.Range(0, _enemys.Length)];
            Enemy spawnedEnemy = Instantiate(_enemy, _points[Random.Range(0, _points.Length)].transform.position, Quaternion.identity);
            Vector3 direction = new Vector3(Random.Range(_minSpawnRange, _maxSpawnRange), 0, Random.Range(_minSpawnRange, _maxSpawnRange)).normalized;

            spawnedEnemy.SetParametrs(direction);
        }
    } 
}
