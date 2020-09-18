using UnityEngine;

public class EnemyStartEventManager : MonoBehaviour {
    public delegate void EnableAction();
    public static event EnableAction onEnable;

    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Key")
                {
                    if (onEnable != null)
                    {
                        onEnable();
                    }
                }
            }
        }
    }
}