using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto com o qual o jogador colidiu é uma moeda
        if (other.CompareTag("Coin"))
        {
            // Adicione a lógica de coleta de moeda aqui, como aumentar a pontuação do jogador
            // e destruir a moeda
            Destroy(other.gameObject);
        }
    }
}
