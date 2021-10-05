
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 2.5f;
    public Transform interactionTransform;
    public Camera playerCamera;
    public Transform player;

    public virtual void Interact()
    {
        //this method is meant to be overwritten
        Debug.Log("Interacting with " + transform.name);
       
    }
    void OnDrawGizmosSelected()
    {
        //if (interactionTransform == null)
        //    interactionTransform = Transform;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            RaycastHit hit;

            if (distance <= radius & Physics.Raycast(ray, out hit))
			{
                Interact();
			}

            
          

            
        }
    }
}
