using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTheFireTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    private void OnTriggerEnter(Collider collider)
    {
        _fire.SetActive(true);
    }
}
