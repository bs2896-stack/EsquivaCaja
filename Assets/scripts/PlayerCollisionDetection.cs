using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OncollisionEnter (Collision col)

    {
        if (col.gameObject.CompareTag("Caja"))
        {
           
        }
         Destroy(gameObject);



    }
}
