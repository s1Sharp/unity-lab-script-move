using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleInterface : MonoBehaviour
{
    [SerializeField]
    GameObject go;
    public bool changeObject = false;

    IInteractable interactable;
    // Start is called before the first frame update
    void Start()
    {
        interactable = go.GetComponent<IInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (changeObject)
        {
            interactable = go.GetComponent<IInteractable>();
            changeObject = false;
        }
        interactable.Interact();
    }
}
