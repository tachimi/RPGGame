using System;
using UnityEngine;

public class BreakBridgeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _bridge;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            if (collider.gameObject.GetComponent<Outline>().OutlineWidth == 0)
            {
                _bridge.GetComponent<Bridge>().Break();
            }
        }
    }
}