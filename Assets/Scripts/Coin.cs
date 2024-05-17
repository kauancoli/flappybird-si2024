using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 1f; // Velocidade de movimento da moeda

    private void Update()
    {
        // Move a moeda para a esquerda com a velocidade especificada
        transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
