using UnityEngine;
using UnityEngine.UI;

namespace DeerCat.TunnelRush
{
	public class VolumeButton : MonoBehaviour
	{
		public Sprite[] sprites;

		private Image image;

		private int spriteIdx;

		public SettingsScreen settings { get; set; }

		private void Awake()
		{
		}

		public void SetVolume(float vol)
		{
		}

		private void OnClick()
		{
		}
	}
}
