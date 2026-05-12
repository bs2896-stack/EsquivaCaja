using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorTiempo : MonoBehaviour
{
   private TMP_Text timerText;
    private float tiempoActual = 0f;
    private bool corriendo = true;

    void Start()
    {
        timerText = GetComponent<TMP_Text>(); // lo agarra solo, están en el mismo objeto
    }

    void Update()
    {
        if (!corriendo) return;

        tiempoActual += Time.deltaTime;
        timerText.text =  tiempoActual.ToString("F2");
    }

    public void PausarTimer()
    {
        corriendo = false;
    }

    public void ReiniciarTimer()
    {
        tiempoActual = 0f;
        corriendo = true;
    }
}
