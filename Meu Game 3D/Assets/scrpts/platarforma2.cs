using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platarforma2 : MonoBehaviour
{
    public int moedagi = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * moedagi * Time.deltaTime,Space.World);
    }
}
