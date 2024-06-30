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
        while (isWork)
        {
            yield return new WaitForSeconds(1);
            _enemy = _enemys[Random.Range(0, _enemys.Length)];
            Instantiate(_enemy, _points[Random.Range(0, _points.Length)].transform.position, Quaternion.identity);
            Quaternion rotate = Quaternion.Euler(0, Random.Range(0, 361), 0);

            _enemy.SetParametrs(_speedEnemy, rotate);
        }
    }
}
