using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour, IEffectManager
{
	[SerializeField] private ParticleSystem effect = null;

	private void OnEnable()
	{
		Locator<IEffectManager>.Bind(this);
	}

	private void OnDisable()
	{
		Locator<IEffectManager>.Unbind(this);
	}

	public virtual void PlayEffect(Vector3 position)
	{
		effect.Stop();
		effect.transform.position = position;
		effect.Play();
	}
}
