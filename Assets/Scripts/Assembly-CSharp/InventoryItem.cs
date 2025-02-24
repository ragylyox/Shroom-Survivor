using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Header("UI")]
	public Image image;

	public void OnBeginDrag(PointerEventData eventData)
	{
		image.raycastTarget = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		base.transform.position = Input.mousePosition;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		image.raycastTarget = true;
	}
}
