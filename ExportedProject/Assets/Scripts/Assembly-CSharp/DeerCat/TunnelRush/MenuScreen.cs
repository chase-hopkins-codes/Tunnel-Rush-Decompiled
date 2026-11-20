using DeerCat.SimpleTween;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class MenuScreen : MonoBehaviour
	{
		public enum TransitionDirection
		{
			Forward = 0,
			Back = 1
		}

		public GameObject defaultUIItem;

		private CanvasGroup canvasGroup;

		private Transform panelXfm;

		private Tween alphaTween;

		private Tween rotationTween;

		public CanvasGroup CanvasGroup
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		public virtual void Show(float fade, TransitionDirection direction = TransitionDirection.Forward, Callback callback = null)
		{
		}

		public virtual void Hide(float fade, TransitionDirection direction = TransitionDirection.Back, Callback callback = null)
		{
		}
	}
}
