using UnityEngine;

public class GunView : MonoBehaviour
{
	private Vector3 baseScale = new Vector3(0.7f, 0.7f, 0.7f);

	private bool isPhone;

	private bool isFirst = true;

	private float zRot;

	private float yRot;

	private Vector3 startPos;

	private void OnEnable()
	{
		base.transform.localScale = baseScale;
		if (SystemInfo.deviceType == DeviceType.Handheld)
		{
			isPhone = true;
		}
		isFirst = true;
	}

	private void Update()
	{
		if (isPhone)
		{
			if (Input.touchCount > 0)
			{
				if (isFirst)
				{
					isFirst = false;
					startPos = Input.GetTouch(0).position;
					return;
				}
				zRot += (Input.GetTouch(0).position.y - startPos.y) * 0.09f;
				zRot = Mathf.Clamp(zRot, -55f, 55f);
				yRot += (Input.GetTouch(0).position.x - startPos.x) * 0.25f;
				startPos = Input.GetTouch(0).position;
				ScaleUp();
			}
			else
			{
				isFirst = true;
				zRot = Mathf.Lerp(zRot, 0f, 0.08f);
				yRot = Mathf.Lerp(yRot, 0f, 0.08f);
				ScaleDown();
			}
			base.transform.eulerAngles = new Vector3(0f, 90f + yRot, zRot);
			return;
		}
		if (Input.GetMouseButton(0))
		{
			if (isFirst)
			{
				isFirst = false;
				startPos = Input.mousePosition;
				return;
			}
			zRot += (Input.mousePosition.y - startPos.y) * 0.1f;
			zRot = Mathf.Clamp(zRot, -55f, 55f);
			yRot += (Input.mousePosition.x - startPos.x) * 0.3f;
			startPos = Input.mousePosition;
			ScaleUp();
		}
		else
		{
			isFirst = true;
			zRot = Mathf.Lerp(zRot, 0f, 0.2f);
			yRot = Mathf.Lerp(yRot, 0f, 0.2f);
			ScaleDown();
		}
		base.transform.eulerAngles = new Vector3(0f, 90f + yRot, zRot);
	}

	private void ScaleUp()
	{
		base.transform.localScale = Vector3.Lerp(base.transform.localScale, Vector3.one, 0.075f);
	}

	private void ScaleDown()
	{
		base.transform.localScale = Vector3.Lerp(base.transform.localScale, baseScale, 0.075f);
	}
}
