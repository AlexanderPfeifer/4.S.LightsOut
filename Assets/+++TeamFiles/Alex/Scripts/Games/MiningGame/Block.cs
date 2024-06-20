using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if ((1 << col.gameObject.layer) == FindObjectOfType<MiningGame>().deleteZone)
        {
            FindAnyObjectByType<MiningGame>().allBlocks.Remove(transform);
            Destroy(gameObject);
        }
    }
}