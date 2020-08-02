using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggedEffectManager : EffectManager
{
	public override void PlayEffect(Vector3 position)
	{
		Debug.Log($"EffectPos: {position.ToString()}");
		base.PlayEffect(position);
	}
}
