using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Referencia a posição do jogador:
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        // Calculado apenas uma vez
        // posicao da camera - posicao do jogador
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Roda todo frame mas após todos os update feitos
        transform.position = player.transform.position + offset;
    }
}
