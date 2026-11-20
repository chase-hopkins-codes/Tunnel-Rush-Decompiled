using System.Collections.Generic;
using DeerCat.SimpleTween;
using UnityEngine;
using UnityEngine.UI;

namespace DeerCat.TunnelRush
{
	public class HUD : GUIScreen
	{
		public float showArrowsTime;

		public GameObject opponentIndicatorTextPrefab;

		private CanvasGroup canvasGroup;

		private Text distanceText;

		private Text gemText;

		private Text speedText;

		private Text countdownText;

		private RectTransform distancePanel;

		private RectTransform speedPanel;

		private RectTransform progresssBar;

		private RectTransform progressSplitBar;

		private RectTransform progressIcon;

		private RectTransform leftArrow;

		private RectTransform rightArrow;

		private Tween kickTween;

		private Tween shakeTween;

		private Text playersRemainingCount;

		private List<Text> opponentTexts;

		private Tween scrollTween;

		public override void Initialise()
		{
		}

		private void Update()
		{
		}

		protected override void OnAboutToShow(TransitionDirection transition)
		{
		}

		public void OnAboutToStartGame()
		{
		}

		public void OnOpponentCrashed(string name)
		{
		}

		public void OnGemCollected(bool reachedGemTarget)
		{
		}
	}
}
