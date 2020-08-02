using UnityEngine;

public class DummyEffectManager : IEffectManager
{
	public void PlayEffect(Vector3 position)
	{
		Debug.Log("Dummy PlayEffect");
	}
}
