using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManeger : MonoBehaviour
{

    public TextMeshProUGUI hud, msgvi;
    public int restantes;
   
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;
        
        hud.text = $"pegue todas: {restantes}";
    }

    public void subtraimoedas(int valor)
    {
        restantes = restantes - valor;
        hud.text = $"pegue todas: {restantes}";
        
        //ganhou
        if (restantes <= 0)
        {
            msgvi.text = "pabens";
        }
    }

    
    void Update()
    {
        
    }
}
