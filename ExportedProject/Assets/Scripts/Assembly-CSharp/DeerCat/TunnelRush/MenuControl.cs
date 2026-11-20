using System.Collections.Generic;
using DeerCat.SimpleTween;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class MenuControl : MonoBehaviour
	{
		private GUIScreen[] screens;

		private GUIScreen currentChrome;

		private static MenuControl instance;

		private Dictionary<string, GUIScreen> menus;

		private List<GUIScreen> menuStack;

		private GUIScreen currentScreen;

		private GameObject adLoadingScreen;

		public static GUIScreen CurrentScreen
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int MenuStackDepth
		{
			get
			{
				return 0;
			}
		}

		public static bool IsScreenOpen(string name)
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void AddMenuScreen(GUIScreen screen)
		{
		}

		private void OpenMenuScreen(string name, Callback callback = null, TransitionDirection transition = TransitionDirection.Forward)
		{
		}

		private void OpenMenuScreen(GUIScreen screen, Callback callback = null, TransitionDirection transition = TransitionDirection.Forward)
		{
		}

		public void GoBack()
		{
		}

		private void PreviousMenu(Callback callback)
		{
		}

		private void HideAll()
		{
		}

		public static void FadeIn(float duration = 0f, Callback callback = null)
		{
		}

		public static void FadeOut(float duration = 1f, Callback callback = null)
		{
		}

		public static void RegisterMenu(GUIScreen screen)
		{
		}

		public static bool HasMenu(GUIScreen screen)
		{
			return false;
		}

		public static void OpenMenu(string name, Callback callback = null)
		{
		}

		public static void CloseMenu(Callback callback = null)
		{
		}

		public static void HideAllImmediate()
		{
		}

		public static GUIScreen FindScreen(string name)
		{
			return null;
		}

		public static void ShowAdLoadingScreen(bool show)
		{
		}

		public static void EnableMouseInput(bool enable)
		{
		}
	}
}
