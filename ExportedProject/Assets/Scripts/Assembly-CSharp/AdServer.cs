public abstract class AdServer
{
	public virtual void InitializeAds()
	{
	}

	public virtual void DoUpdate()
	{
	}

	public virtual void PrecacheAdvert()
	{
	}

	public virtual void StartButtonPressed()
	{
	}

	public virtual void OnPowerUp()
	{
	}

	public abstract void ShowAdvert();

	public abstract void ShowRewardedAdvert(AdvertManager.RewardedAdCompleted callback);
}
