using UnityEngine;
using UnityEngine.Audio;

namespace DeerCat.TunnelRush
{
	public class SettingsScreen : GUIScreen
	{
		public AudioMixer audioMixer;

		private RectTransform confirmDialog;

		private CanvasGroup confirmGroup;

		public override void Initialise()
		{
		}

		protected override void OnAboutToShow(TransitionDirection transition)
		{
		}

		private void SetInitialAudioVol()
		{
		}

		public void OnVolumeChanged(float vol)
		{
		}

		public void OnDifficultyPressed()
		{
		}

		private void SetDifficultyString()
		{
		}

		public void ResetProgress()
		{
		}

		public void OpenConfirmDialog()
		{
		}

		public void CloseConfirmDialog()
		{
		}

		public void GoBack()
		{
		}

		public static float dBToLinear(float db)
		{
			return 0f;
		}

		public static float linearTodB(float linear)
		{
			return 0f;
		}
	}
}
