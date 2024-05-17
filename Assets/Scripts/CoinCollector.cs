using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto com o qual o jogador colidiu � uma moeda
        if (other.CompareTag("Coin"))
        {
            // Adicione a l�gica de coleta de moeda aqui, como aumentar a pontua��o do jogador
            // e destruir a moeda
            Destroy(other.gameObject);
        }
    }
}
