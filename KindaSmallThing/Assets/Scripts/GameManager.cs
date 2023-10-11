using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
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

        HUD.text = "Jiggies: " + restantes;
    }
    
    public void SubtrairMoedas(int valor){
        restantes -= valor;
        HUD.text = "Jiggies: " + restantes;
        source.PlayOneShot(clipCoin);

        if(restantes <= 0){
            WinMsg.text = "CONGRATS!!!!1!";
            source.Stop();
            source.PlayOneShot(clipWin);

            Invoke("ProxFase", 5);
        }
        
        // if()
    }

    void ProxFase()
    {
        SceneManager.LoadScene("Fase 2");
    }
}
