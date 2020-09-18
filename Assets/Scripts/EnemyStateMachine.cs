using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    Inactive,
    Targeting,
    Charging,
    Dead
}

public class EnemyStateMachine : MonoBehaviour
{
    public EnemyState state;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case EnemyState.Inactive:
                // Entry (none)
                // Do (none)
                // Exit (handled by event call)
                break;
            case EnemyState.Targeting:
                // Entry
                // Do
                // Exit
                break;
            case EnemyState.Charging:
                // Entry
                // Do
                // Exit
                break;
            case EnemyState.Dead:
            default:
                // Entry
                // Do
                // Exit
                break;
        }
    }

    void OnEnable() {
        EnemyStartEventManager.onEnable += EnableEnemy;
    }

    void OnDisable() {
        EnemyStartEventManager.onEnable -= EnableEnemy;
    }

    void EnableEnemy()
    {
        if (state == EnemyState.Inactive)
        {
            state = EnemyState.Targeting;
        }
    }
}
