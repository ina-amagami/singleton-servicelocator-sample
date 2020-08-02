using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectPlayer : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if (!Locator<IEffectManager>.IsValid())
				{
					Locator<IEffectManager>.Bind(new DummyEffectManager());
				}

				Locator<IEffectManager>.I.PlayEffect(hit.point);
			}
		}
	}
}
