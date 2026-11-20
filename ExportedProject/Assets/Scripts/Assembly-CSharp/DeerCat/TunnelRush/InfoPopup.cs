using DeerCat.SimpleTween;
using UnityEngine;
using UnityEngine.UI;

namespace DeerCat.TunnelRush
{
	public class InfoPopup : MonoBehaviour
	{
		private CanvasGroup canvasGroup;

		private Text text;

		private Tween alphaTween;

		private Tween rotationTween;

		private Tween countdownTween;

		private bool isShowing;

		private void Start()
		{
		}

		private void ShowInfoPopup(float duration, float fadeTime)
		{
		}

		public void ShowMessage(string message, float duration, float fadeTime)
		{
		}
	}
}
