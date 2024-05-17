using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab da moeda
    public float spawnRate = 2f; // Taxa de gera��o de moedas
    public float minY = -2f; // Altura m�nima da gera��o
    public float maxY = 2f; // Altura m�xima da gera��o

    private void Start()
    {
        // Chama o m�todo de gera��o de moedas repetidamente com base na taxa de gera��o
        InvokeRepeating("SpawnCoin", 0f, spawnRate);
    }

    private void SpawnCoin()
    {
        // Calcula uma posi��o aleat�ria dentro dos limites definidos
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);

        // Instancia uma moeda na posi��o aleat�ria
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
