using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Audio;

namespace DeerCat
{
	public class SoundManager : MonoBehaviour
	{
		public AudioMixerGroup masterAudio;

		public AudioClip[] sounds;

		public AudioClip[] music;

		private static SoundManager soundMan;

		private AudioSource[] sfxAudio;

		private AudioSource musicAudio;

		private int maxSfx;

		private int nextSfxIdx;

		private bool isMusicPlaying;

		public static float MusicVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private int NextSfxIdx()
		{
			return 0;
		}

		private void Awake()
		{
		}

		public static void PlaySfx(string sfxName)
		{
		}

		public static void PlaySfx(AudioClip clip)
		{
		}

		public static void PlayMusic(string trackName)
		{
		}

		public static bool IsMusicPlaying()
		{
			return false;
		}

		public static void PauseMusic(float fadeTime)
		{
		}

		public static void UnpauseMusic()
		{
		}

		private void PlaySound(string soundName, AudioClip[] pool, AudioSource audioOut)
		{
		}

		private void PlaySound(AudioClip clip, AudioSource audioOut)
		{
		}

		[DebuggerHidden]
		private IEnumerator FadeMusicOut(float time)
		{
			return null;
		}
	}
}
