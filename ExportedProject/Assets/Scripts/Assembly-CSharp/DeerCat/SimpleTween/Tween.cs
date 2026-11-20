namespace DeerCat.SimpleTween
{
	public abstract class Tween
	{
		private float duration;

		private float delay;

		private float t;

		private Easing ease;

		private Callback callback;

		public bool useRealTime;

		public bool IsComplete
		{
			get
			{
				return false;
			}
		}

		public Callback Callback
		{
			get
			{
				return null;
			}
		}

		public Tween()
		{
		}

		public Tween(float dur)
		{
		}

		protected abstract void SetValue(float blend);

		public void Update(float dT)
		{
		}

		public Tween OnCompleted(Callback cb)
		{
			return null;
		}

		public Tween Delay(float d)
		{
			return null;
		}

		public Tween Ease(Easing e)
		{
			return null;
		}

		public Tween UseRealTime(bool b)
		{
			return null;
		}

		public void SetTVal(float tval)
		{
		}

		private float CalcEase(float t)
		{
			return 0f;
		}
	}
}
