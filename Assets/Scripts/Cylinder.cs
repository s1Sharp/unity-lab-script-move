using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Cylinder movement");
        this.transform.Rotate(1.0f, 1.0f, 1.0f, Space.Self);
    }
}
