using DeerCat.SimpleTween;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DeerCat.TunnelRush
{
	public class GUIItem : MonoBehaviour, ISubmitHandler, IMoveHandler, IEventSystemHandler
	{
		public enum AnimType
		{
			None = 0,
			Fade = 1,
			Scale = 2,
			ScaleFade = 3,
			SlideScreenLeft = 4,
			SlideScreenRight = 5,
			SlideScreenTop = 6,
			SlideScreenBottom = 7,
			SlideFadeLeft = 8,
			SlideFadeRight = 9,
			SlideFadeTop = 10,
			SlideFadeBottom = 11,
			RotateX = 12
		}

		public AnimType inAnim;

		public Easing easingIn;

		public float animTimeIn;

		public float delayIn;

		public AnimType outAnim;

		public Easing easingOut;

		public float animTimeOut;

		public float delayOut;

		public bool dontWaitForItem;

		public bool fadeColour;

		public bool passThroughCancelEvent;

		private RectTransform rect;

		private CanvasRenderer canvasRenderer;

		private Image image;

		private Text text;

		private CanvasGroup canvasGroup;

		private Tween tween;

		private Tween fadeTween;

		private Vector2 startPos;

		private Vector3 startScale;

		private Vector2 offScreenPosInAnim;

		private Vector2 offScreenPosOutAnim;

		private float startAlpha;

		private Color startColor;

		private bool doneInit;

		private void Init()
		{
		}

		private Vector2 GetOffScreenPos(AnimType anim, Rect canvasRect, RectTransform item)
		{
			return default(Vector2);
		}

		private Easing GetEasing(Easing ease, TransitionDirection transition)
		{
			return Easing.EaseLinear;
		}

		private void SetAlpha(float alpha)
		{
		}

		private float GetAlpha()
		{
			return 0f;
		}

		private void AnimateIn(AnimType anim, float animTime, float delay, Easing ease, Vector2 offScreenPos, Callback callback)
		{
		}

		private void AnimateOut(AnimType anim, float animTime, float delay, Easing ease, Vector2 offScreenPos, Callback callback)
		{
		}

		public void AnimateForward(Callback callback, TransitionDirection transition)
		{
		}

		public void AnimateBackward(Callback callback, TransitionDirection transition)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}
	}
}
