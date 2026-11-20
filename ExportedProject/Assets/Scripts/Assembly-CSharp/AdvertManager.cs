using UnityEngine;

public class AdvertManager : MonoBehaviour
{
	public delegate void RewardedAdCompleted(bool success);

	private static AdvertManager instance;

	private AdServer adServer;

	private int deathsSinceAd;

	private float lastAdTime;

	private static bool adsEnabled;

	public static bool AdvertsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
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

	private void ShowAdvert()
	{
	}

	private void PrecacheAdvert()
	{
	}

	private void ShowRewardedAdvert(RewardedAdCompleted callback)
	{
	}

	public static void ShowAd()
	{
	}

	public static void ShowRewardedAd(RewardedAdCompleted callback)
	{
	}

	public static void MaybeShowAd()
	{
	}

	public static void MaybePrecacheAd()
	{
	}

	public static void StartButtonPressed()
	{
	}

	public static void RecordRewardAdWatched()
	{
	}

	public static void RecordInterstitialWatched()
	{
	}

	public static void OnPowerUp()
	{
	}
}
