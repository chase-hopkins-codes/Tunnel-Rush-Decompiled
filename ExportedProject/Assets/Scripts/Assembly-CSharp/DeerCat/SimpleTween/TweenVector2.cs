using UnityEngine;

namespace DeerCat.SimpleTween
{
	public class TweenVector2 : Tween
	{
		protected Setter<Vector2> setter;

		protected Vector2 startVal;

		protected Vector2 endVal;

		public TweenVector2()
		{
		}

		public TweenVector2(Setter<Vector2> set, Vector2 start, Vector2 end, float duration)
		{
		}

		protected override void SetValue(float blend)
		{
		}
	}
}
