
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 2f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
