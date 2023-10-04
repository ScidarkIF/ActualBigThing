using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HUD, WinMsg;
    public int restantes;
    public AudioClip clipCoin, clipWin;

    private AudioSource source;

    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;

        HUD.text = "GAY SEX: " + restantes;
    }
    
    public void SubtrairMoedas(int valor){
        restantes -= valor;
        HUD.text = "GAY SEX: " + restantes;
        source.PlayOneShot(clipCoin);

        if(restantes <= 0){
            WinMsg.text = "AYYYYYY LMAO";
            source.Stop();
            source.PlayOneShot(clipWin);

        }
    }
    void Update()
    {
        
    }
}
