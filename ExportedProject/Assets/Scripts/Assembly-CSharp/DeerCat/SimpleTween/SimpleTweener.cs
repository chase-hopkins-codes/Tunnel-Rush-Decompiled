using System.Collections.Generic;
using UnityEngine;

namespace DeerCat.SimpleTween
{
	public class SimpleTweener : MonoBehaviour
	{
		public int activeTweens;

		private List<Tween> tweens;

		public static SimpleTweener instance;

		public float globalTimeScale;

		private void Update()
		{
		}

		public static Tween AddTween<T>(Getter<T> getter, Setter<T> setter, T end, float duration)
		{
			return null;
		}

		public static void RemoveTween(Tween tween)
		{
		}

		public static void ForceComplete(Tween tween)
		{
		}

		public static Tween DelayCall(Callback func, float duration)
		{
			return null;
		}
	}
}
