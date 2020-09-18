using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerInteraction : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        {
            PlayerScaleController scaleController = 
                other.gameObject.GetComponent<PlayerScaleController>();
            
            if (scaleController != null)
            {
                scaleController.IncreaseScale();
            }
        }
    }
}
