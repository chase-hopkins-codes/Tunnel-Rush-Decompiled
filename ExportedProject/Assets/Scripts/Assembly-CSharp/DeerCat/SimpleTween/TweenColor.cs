using UnityEngine;

namespace DeerCat.SimpleTween
{
	public class TweenColor : Tween
	{
		protected Setter<Color> setter;

		protected Color startVal;

		protected Color endVal;

		public TweenColor()
		{
		}

		public TweenColor(Setter<Color> set, Color start, Color end, float duration)
		{
		}

		protected override void SetValue(float blend)
		{
		}
	}
}
