using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab da moeda
    public float spawnRate = 2f; // Taxa de geração de moedas
    public float minY = -2f; // Altura mínima da geração
    public float maxY = 2f; // Altura máxima da geração

    private void Start()
    {
        // Chama o método de geração de moedas repetidamente com base na taxa de geração
        InvokeRepeating("SpawnCoin", 0f, spawnRate);
    }

    private void SpawnCoin()
    {
        // Calcula uma posição aleatória dentro dos limites definidos
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);

        // Instancia uma moeda na posição aleatória
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
