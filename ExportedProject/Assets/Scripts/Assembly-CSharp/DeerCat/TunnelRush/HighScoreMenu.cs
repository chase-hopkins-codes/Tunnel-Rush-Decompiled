using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class HighScoreMenu : GUIScreen
	{
		private class PlayerRow
		{
			public GameObject uiRow;

			public string name;

			public float distance;

			public float timeTillPredestinedCrash;

			public ChallengeManager.Opponent opponent;
		}

		public Color localPlayerColour;

		public GameObject hiscoreRowPrefab;

		private GameObject restartButton;

		private PlayerRow[] playerRows;

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

		protected override void OnAboutToShow(TransitionDirection transition)
		{
		}

		private int GenSortedPlayerList()
		{
			return 0;
		}

		private void KickItem(Transform item, float amount, float time)
		{
		}
	}
}
