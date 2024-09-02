using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class camerafolow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset;
    public int suavi = 5;

    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        offset = alvo.position - transform.position;
    }

    
    void Update()
    {
        Vector3 posfinal = alvo.position - offset;
        transform.position = Vector3.Lerp(transform.position,posfinal,suavi*Time.deltaTime);
    }
}
