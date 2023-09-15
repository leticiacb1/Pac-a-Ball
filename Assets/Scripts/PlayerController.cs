using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{   
    // Referencia ao corpo rígido que queremos mexer
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private Rigidbody rb; 
    private int count;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Pega a referencia RigidBody ligada ao Player

        // Valor inicial da contagem dos PickUps:
        count = 0;
        setCountText();
        winTextObject.SetActive(false); // Desativa o texto no inicio do jogo
    }

    void OnMove(InputValue movementValue){
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void setCountText(){
        countText.text = "Count : " + count.ToString();

        if(count >= 12){
            winTextObject.SetActive(true); // Mostra texto de vitória
        }
    }

    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }

    // Desativar objetos que o player collidir com
    // Para que isso não ocorra ocm o chão e com as paredes, adicionamos Tag aos objetos pegaveis
    private void OnTriggerEnter(Collider other){
        
        if(other.gameObject.CompareTag("PickUp")){
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }
}
