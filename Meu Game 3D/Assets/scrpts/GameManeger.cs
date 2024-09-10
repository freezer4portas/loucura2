using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManeger : MonoBehaviour
{

    public TextMeshProUGUI hud, msgvi;
    public int restantes;
    public AudioClip clipmoeda, clipvitoria;

    private AudioSource Source;
   
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;
        
        hud.text = $"pegue todas: {restantes}";
        TryGetComponent(out Source);
    }

    public void subtraimoedas(int valor)
    {
        restantes = restantes - valor;
        hud.text = $"pegue todas: {restantes}";
        Source.PlayOneShot(clipmoeda);
        
        //ganhou
        if (restantes <= 0)
        {
            msgvi.text = "pabens";
            Source.Stop();
            Source.PlayOneShot(clipvitoria);
        }
    }

    
    void Update()
    {
        
    }
}
