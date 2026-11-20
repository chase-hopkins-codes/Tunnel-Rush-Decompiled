using UnityEngine;

namespace DeerCat.TunnelRush
{
	public abstract class Interactable : MonoBehaviour
	{
		protected virtual void Start()
		{
		}

		public void OnCollected()
		{
		}

		protected abstract void Apply();
	}
}
