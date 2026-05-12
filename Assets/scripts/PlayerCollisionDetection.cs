using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    private ContadorTiempo contadorTiempo;
    // Start is called before the first frame update
    void Start()
    {
         contadorTiempo = FindObjectOfType<ContadorTiempo>();
    }

    void OnCollisionEnter (Collision col)

    {
        if (col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
        
        if (col.gameObject.CompareTag("Caja"))
        {
            contadorTiempo.PausarTimer();
        }



    }
}
