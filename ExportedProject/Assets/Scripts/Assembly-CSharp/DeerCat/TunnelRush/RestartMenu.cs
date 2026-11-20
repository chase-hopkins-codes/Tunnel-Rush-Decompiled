using UnityEngine;
using UnityEngine.UI;

namespace DeerCat.TunnelRush
{
	public class RestartMenu : GUIScreen
	{
		private CanvasGroup normalScreen;

		private CanvasGroup newRecordScreen;

		private Text distanceText;

		private Text oldRecordText;

		private Text newRecordText;

		private GameObject continueWithAdButton;

		private GameObject restartButton;

		private const int maxRevives = 1;

		public override void Initialise()
		{
		}

		public override void WhileOpen()
		{
		}

		public void OnRestartPressed()
		{
		}

		public void OnExitPressed()
		{
		}

		public void OnContinuePressed()
		{
		}

		protected override void OnAboutToShow(TransitionDirection transition)
		{
		}

		private void KickItem(Transform item, float amount, float time)
		{
		}
	}
}
