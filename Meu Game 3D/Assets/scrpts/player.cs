using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;

    void Start()
    {
        TryGetComponent(out rb);

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");// -1 esquerda,0 nada, 1direita
        float v = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        
    }
}
