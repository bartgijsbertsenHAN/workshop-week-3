using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaleController : MonoBehaviour
{
    public Vector3 scaleDifference = new Vector3(.5f, .5f, .5f);

    public void IncreaseScale()
    {
        transform.localScale += scaleDifference;
    }

    public void DecreaseScale()
    {
        transform.localScale -= scaleDifference;
    }
}
