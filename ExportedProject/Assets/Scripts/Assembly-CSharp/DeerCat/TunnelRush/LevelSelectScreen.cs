using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class LevelSelectScreen : GUIScreen
	{
		public int levelsPerPage;

		public int totalLevels;

		public LevelButton levelButton;

		public Color[] pageColors;

		private LevelButton[] buttons;

		private int currentPage;

		private bool isSwipingGrid;

		private float dragStartX;

		private int NumPages
		{
			get
			{
				return 0;
			}
		}

		public override void Initialise()
		{
		}

		protected override void OnAboutToShow(TransitionDirection transition)
		{
		}

		private GameObject GetButton(int levelIdx)
		{
			return null;
		}

		private void SetPage(int page)
		{
		}

		public void GoToPrevPage()
		{
		}

		public void GoToNextPage()
		{
		}

		public void GoBack()
		{
		}

		private void Update()
		{
		}
	}
}
