using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_controller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col){
        Destroy(col.gameObject);
        
    }
}
