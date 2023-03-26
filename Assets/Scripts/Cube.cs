using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IInteractable
{
    private bool west = true;
    public void Interact()
    {
        Debug.Log("Cube movement");
        Vector3 newPos = this.transform.position;
        if (west)
        {
            newPos.y += 1;
            newPos.x += 1;
            this.transform.SetPositionAndRotation(newPos, this.transform.rotation);
            west = false;
        }
        else
        {
            newPos.y -= 1;
            newPos.x -= 1;
            this.transform.SetPositionAndRotation(newPos, this.transform.rotation);
            west = true;
        }
    }
}
