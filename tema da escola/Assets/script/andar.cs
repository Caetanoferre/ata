using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andar : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public class PlayerMovement : MonoBehaviour
    {

        public float speed = 5f; // Velocidade de movimento do jogador
    }
        // Update is called once per frame
        void Update()
    {


        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Aplica o movimento baseado na direção
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
    }

}
