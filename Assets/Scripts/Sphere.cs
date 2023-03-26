using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IInteractable
{
    private bool west = true;
    private float rotateMax = 0.0f;
    public void Interact()
    {
        Debug.Log("Sphere movement");
        Vector3 newPos = this.transform.position;
        if (west && rotateMax < 1.0f)
        {
            rotateMax += 0.01f;
            newPos.y += 0.01f;
            this.transform.SetPositionAndRotation(newPos, this.transform.rotation);
        }
        else
        {
            west = false;
        }
        if (!west && rotateMax > 0.0f)
        {
            rotateMax -= 0.01f;
            newPos.y -= 0.01f;
            this.transform.SetPositionAndRotation(newPos, this.transform.rotation);
        } else
        {
            west = true;
        }
    }
}
