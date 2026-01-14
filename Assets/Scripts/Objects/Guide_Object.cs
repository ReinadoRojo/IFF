using UnityEngine;

public class Guide_Object : Bases.InteractableObject
{
    [SerializeField]
    GameObject overlay;
    public override void OnClick()
    {
        if (overlay != null) { overlay.SetActive(true); }
        Debug.Log("Called onclick for this object");
    }
}
