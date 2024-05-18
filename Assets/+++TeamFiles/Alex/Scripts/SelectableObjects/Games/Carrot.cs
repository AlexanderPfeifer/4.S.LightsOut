using System;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    [SerializeField] private LayerMask floorLayer;
    private Vector3 respawnPoint;

    private void Start() => respawnPoint = transform.position;
    
    private void OnTriggerExit(Collider col)
    {
        if ((1 << col.gameObject.layer) == floorLayer.value)
        {
            transform.position = respawnPoint;
            UIScoreCounter.instance.combo = 1;
            UIScoreCounter.instance.counterUntilMultiply = 0;
        }
    }
}