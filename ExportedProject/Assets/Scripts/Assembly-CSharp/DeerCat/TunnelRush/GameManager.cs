using DeerCat.SimpleTween;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class GameManager : MonoBehaviour
	{
		public enum GameState
		{
			InMenus = 0,
			Playing = 1,
			Paused = 2,
			Countdown = 3,
			Dead = 4
		}

		public enum GameMode
		{
			Classic = 0,
			Vs = 1
		}

		public AdvertMode advertMode;

		public int numRunsBetweenAdverts;

		private int runCount;

		private GameState state;

		private GameMode gameMode;

		private PlayerControl player;

		private LevelManager levelManager;

		private InfoPopup infoPopup;

		private CanvasGroup screenFade;

		private Tween fadeTween;

		private float targetDistance;

		private bool brokenRecord;

		private float previousLevelsDistance;

		private float countdownTimer;

		private int gameVersion;

		private int buildVersion;

		private static GameManager instance;

		private bool initialised;

		public static int GameVersionCode
		{
			get
			{
				return 0;
			}
		}

		public static GameManager Instance
		{
			get
			{
				return null;
			}
		}

		public static bool AllAdsDisabled
		{
			get
			{
				return false;
			}
		}

		public static bool RewardAdsDisabled
		{
			get
			{
				return false;
			}
		}

		public static PlayerControl Player
		{
			get
			{
				return null;
			}
		}

		public static LevelManager LevelManager
		{
			get
			{
				return null;
			}
		}

		public static float CumulativeDistance
		{
			get
			{
				return 0f;
			}
		}

		public static float LevelDistance
		{
			get
			{
				return 0f;
			}
		}

		public static float CountdownTimer
		{
			get
			{
				return 0f;
			}
		}

		public static int CumulativeLevelCount { get; private set; }

		public static GameState CurrentState
		{
			get
			{
				return GameState.InMenus;
			}
		}

		public static GameMode CurrentMode
		{
			get
			{
				return GameMode.Classic;
			}
		}

		public int GemCount { get; set; }

		public int GemCountTarget { get; set; }

		public int JustCompletedLevelStarScore { get; private set; }

		public static AdvertMode AdvertMode
		{
			get
			{
				return AdvertMode.Disabled;
			}
		}

		public static int CurrentLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int HighestLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static float RecordDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int Difficulty
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int StarScore(int levelIdx)
		{
			return 0;
		}

		private static void SetStarScore(int levelIdx, int score)
		{
		}

		public static void ResetScores()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnterStateMenus()
		{
		}

		private void OnEnterStateGame()
		{
		}

		private void ShowAdvert()
		{
		}

		public void ContinueWithAdvert()
		{
		}

		private void OnEnterStateDeath()
		{
		}

		private void OnEnterStateCompleted()
		{
		}

		public void OnShowMainMenu()
		{
		}

		public void OnStartGamePressed()
		{
		}

		public void OnPlayButtonPressed()
		{
		}

		public void OnVsModeButtonPressed()
		{
		}

		public void OnShowLevelSelect()
		{
		}

		public void OnShowSettings()
		{
		}

		public void GameOver()
		{
		}

		private void RecordLevelScore()
		{
		}

		public void LevelCompleted()
		{
		}

		public void MoveToNextLevelImmediate()
		{
		}

		public void PauseGame()
		{
		}

		public void ResumeGame()
		{
		}

		public static void OnGameOver()
		{
		}

		public static void OnLevelCompleted()
		{
		}

		public static void ShowInfo(string msg)
		{
		}

		private void ScreenFaderFadeIn(float time, Callback onCompletedCB)
		{
		}

		private void ScreenFaderFadeOut(float time)
		{
		}

		public static void FlashScreen(float fadeTime = 0.5f)
		{
		}

		private void Update()
		{
		}
	}
}
