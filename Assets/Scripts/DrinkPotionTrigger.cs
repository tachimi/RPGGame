using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkPotionTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        var player = collider.gameObject;
        player.GetComponent<Outline>().OutlineWidth = gameObject.GetComponent<Outline>().OutlineWidth;
        Destroy(gameObject);
    }
}