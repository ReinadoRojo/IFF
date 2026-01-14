using UnityEngine;

public class Guide_Object : Bases.InteractableObject
{
    public override void OnClick()
    {
        Debug.Log("Called onclick for this object");
    }
}
