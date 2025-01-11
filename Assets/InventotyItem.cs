using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image; // Corrected typo here

    // Drag and drop
    public void OnBeginDrag(PointerEventData eventData) // Corrected capitalization
    {
        image.raycastTarget = false; // Corrected variable name
    }

    public void OnDrag(PointerEventData eventData) // Corrected capitalization
    {
        transform.position = Input.mousePosition; // Added semicolon and corrected the code
    }

    public void OnEndDrag(PointerEventData eventData) // Corrected capitalization and syntax
    {
        image.raycastTarget = true; // Corrected variable name
    }
}
