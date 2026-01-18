using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_script : MonoBehaviour
{
    [SerializeField] private Transform _spawnTransform;
    [SerializeField] private GameObject _coinPrefab;
    private float timer = 0.0f;
    private float maxTime;

    void Start()
    {
        maxTime = Random.value;
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > maxTime)
        {
            Instantiate(_coinPrefab, _spawnTransform.position, _spawnTransform.rotation);
            timer = timer - maxTime;
            maxTime = Random.value;
        }
        
    }

}
