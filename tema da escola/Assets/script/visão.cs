using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visão : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerTransform; // Referência ao transform do jogador
    public float cameraDistance = 5f; // Distância da câmera ao jogador
    public float cameraHeight = 2f; // Altura da câmera em relação ao jogador

        void Update()
        {
            // Verifica se o jogador está definido
            if (playerTransform == null)
            {
                Debug.LogWarning("O jogador não está definido para a câmera.");
                return;
            }

            // Obtém a direção para onde o jogador está olhando
            Vector3 lookDirection = playerTransform.forward;

            // Calcula a posição da câmera
            Vector3 cameraPosition = playerTransform.position - lookDirection * cameraDistance;
            cameraPosition.y = playerTransform.position.y + cameraHeight;

            // Define a posição da câmera
            transform.position = cameraPosition;

            // Faz com que a câmera olhe para o jogador
            transform.LookAt(playerTransform.position);
        }  }
}
