using DeerCat.SimpleTween;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class GUIScreen : MonoBehaviour
	{
		public GameObject defaultUIItem;

		public GUIScreen screenChrome;

		private GUIItem[] guiItems;

		private int activeAnimCount;

		private Callback animCompletedCallback;

		private GameObject selectedItem;

		protected bool isActiveScreen;

		public void InitGUIItems()
		{
		}

		public virtual void Initialise()
		{
		}

		protected virtual void OnAboutToShow(TransitionDirection transition)
		{
		}

		protected virtual void OnShowFinished()
		{
		}

		protected virtual void OnAboutToHide(TransitionDirection transition)
		{
		}

		protected virtual void OnHideFinished()
		{
		}

		public virtual void WhileOpen()
		{
		}

		public virtual void ShowMenu(TransitionDirection transition, Callback callback = null)
		{
		}

		public virtual void HideMenu(TransitionDirection transition, Callback callback = null)
		{
		}

		protected void SetSelectedItem(GameObject item)
		{
		}

		private void ShowCompleted()
		{
		}

		private void HideCompleted()
		{
		}
	}
}
