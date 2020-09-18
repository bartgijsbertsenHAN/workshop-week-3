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

    public float speed;

    public float chargeTime = 3;

    private bool shouldChangeDirection;

    public Transform playerTransform;

    void Update()
    {
        switch (state)
        {
            case EnemyState.Inactive:
                // Entry (none)
                // Do (none)
                // Exit (handled by EnableEnemy)
                break;
            case EnemyState.Targeting:
                // Entry (handled in EnableEnemy)
                // Do
                MoveToPlayer();
                // Exit (handled by function call from collider script)
                break;
            case EnemyState.Charging:
                // Entry
                // Do
                MoveAwayFromPlayer();
                // Exit
                break;
            case EnemyState.Dead:
            default:
                // Entry
                Destroy(this);
                // Do
                // Exit
                break;
        }
    }

    void MoveToPlayer()
    {
        Vector3 movement = transform.position - playerTransform.position;
        movement.Normalize();
        movement *= speed;
        transform.Translate(movement);
    }
    // One of these scripts should change the order of the first line
    void MoveAwayFromPlayer()
    {
        Vector3 movement = transform.position - playerTransform.position;
        movement.Normalize();
        movement *= speed;
        transform.Translate(movement);
    }

    void TargetPlayerAfterCharge()
    {
        state = EnemyState.Targeting;
    }

    void ChargeAfterPlayerHit()
    {
        state = EnemyState.Charging;
        Invoke("TargetPlayerAfterCharge", chargeTime);
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

    public void Kill()
    {
        state = EnemyState.Dead;
    }

}
