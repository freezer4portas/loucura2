using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour

{
    public int moedagi = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            FindObjectOfType<GameManeger>().subtraimoedas(1);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * moedagi * Time.deltaTime,Space.World);
    }
}
