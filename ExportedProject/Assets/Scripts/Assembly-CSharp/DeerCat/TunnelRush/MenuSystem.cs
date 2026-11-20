using System.Collections.Generic;
using DeerCat.SimpleTween;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class MenuSystem : MonoBehaviour
	{
		private Dictionary<string, MenuScreen> screens;

		private Stack<MenuScreen> screenHistory;

		private HUD hud;

		public MenuScreen CurrentScreen
		{
			get
			{
				return null;
			}
		}

		public HUD HUD
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public MenuScreen GetScreen(string name)
		{
			return null;
		}

		public void ShowScreen(MenuScreen screen, float fade = 0.5f, Callback callback = null)
		{
		}

		public void GoBack(float fade = 0.5f, Callback callback = null)
		{
		}

		public void ExitAll(float fade = 0.5f, Callback callback = null)
		{
		}
	}
}
