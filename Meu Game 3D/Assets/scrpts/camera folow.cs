using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class camerafolow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset;

    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        offset = alvo.position - transform.position;
    }

    
    void Update()
    {
        transform.position = alvo.position - offset;
    }
}
