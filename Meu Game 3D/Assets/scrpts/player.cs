using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
public class player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    private Rigidbody rb;
    public bool noCHAO;

    void Start()
    {
        TryGetComponent(out rb);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!noCHAO && collision.gameObject.tag == "chão")
        {
            noCHAO = true;

        }
    }
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");// -1 esquerda,0 nada, 1direita
        float v = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if(Input.GetKeyDown(KeyCode.Space) && noCHAO)
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            
        }





        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(transform.position.y >= 100)
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
