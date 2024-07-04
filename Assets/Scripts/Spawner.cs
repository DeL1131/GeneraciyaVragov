using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy[] _enemys;

    [Tooltip("Интервал спавна противников")]
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _speedEnemy;

    private bool isWork = true;
    private Enemy _enemy;

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_timeSpawn);
        while (isWork)
        {
            yield return waitForSeconds;
            _enemy = _enemys[Random.Range(0, _enemys.Length)];
            Enemy spawnedEnemy = Instantiate(_enemy, _points[Random.Range(0, _points.Length)].transform.position, Quaternion.identity);
            Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;

            spawnedEnemy.SetParametrs(_speedEnemy, direction);
        }
    } 
}
