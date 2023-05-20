using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChestTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _chest;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            _chest.GetComponent<Chest>().Open();
        }
    }
}
