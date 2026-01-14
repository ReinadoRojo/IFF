using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookOverlay : MonoBehaviour
{
    public int page = 0;

    public void CloseOverlay()
    {
        gameObject.SetActive(false);
        page = 0; // Reset page
    }

    public void OpenOverlay()
    {
        gameObject.SetActive(true);
    }
}
