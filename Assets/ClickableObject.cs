using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    private Outline outline;
    private Bases.InteractableObject interactableObject;

    [SerializeField]
    Color outlineColor = Color.white;
       
    // Start is called before the first frame update
    private void Awake()
    {
        outline = gameObject.AddComponent<Outline>();

        outline.OutlineMode = Outline.Mode.OutlineAndSilhouette;
        outline.OutlineColor = outlineColor;
        outline.OutlineWidth = 5f;

        outline.enabled = false;

        // Check for interactableObject script on the gameObject
        interactableObject = GetComponent<Bases.InteractableObject>();

        if(!interactableObject)
        {
            throw new System.Exception("An clickable object needs a InteractableObject script!");
        }
    }

    // When the user puts the mouse over the element, make the object glow.
    // also, should put a tooltip
    // Mouse enter (show outline)
    private void OnMouseEnter()
    {
        outline.enabled = true;

        // TODO: Add tooltip & change cursor
    }

    // Click over object
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) {
            interactableObject.OnClick();
        }
    }

    // Mouse exit (remove outline)
    private void OnMouseExit()
    {
        outline.enabled = false;
    }
}
