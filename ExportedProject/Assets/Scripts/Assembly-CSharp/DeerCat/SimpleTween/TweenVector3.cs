using UnityEngine;

namespace DeerCat.SimpleTween
{
	public class TweenVector3 : Tween
	{
		protected Setter<Vector3> setter;

		protected Vector3 startVal;

		protected Vector3 endVal;

		public TweenVector3()
		{
		}

		public TweenVector3(Setter<Vector3> set, Vector3 start, Vector3 end, float duration)
		{
		}

		protected override void SetValue(float blend)
		{
		}
	}
}
