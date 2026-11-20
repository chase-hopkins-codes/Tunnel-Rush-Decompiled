using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class PlayerControl : MonoBehaviour
	{
		public enum MobileInputMode
		{
			Touch = 0,
			Accelerometer = 1
		}

		public float baseSpeed;

		public float baseSteerSpeed;

		public float accelTime;

		public float maxTilt;

		public float tiltSpeed;

		public Transform ship;

		private float currentTilt;

		public float collisionRadius;

		public bool isInvincible;

		public MobileInputMode inputMode;

		public float accelerometerSensitivity;

		private int interactLayer;

		private Transform root;

		private float acceleration;

		public float speedMultiplier;

		private bool crashed;

		private float invincibleTimer;

		private int numLives;

		private float currentSteer;

		private float rotateSpeed;

		private bool insideTunnel;

		private float tunnelRadius;

		private float jumpDist;

		private float jumpTargetDist;

		private float jumpTopHeight;

		private AnimationCurve jumpCurve;

		public int ReviveCount { get; set; }

		public float TunnelRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool InsideTunnel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float RotateSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Speed
		{
			get
			{
				return 0f;
			}
		}

		public float SteerSpeed
		{
			get
			{
				return 0f;
			}
		}

		public float SpeedMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void Reset()
		{
		}

		public void Revive()
		{
		}

		private float GetSteerInput()
		{
			return 0f;
		}

		public void OnNewSection()
		{
		}

		private void Update()
		{
		}

		public void Jump(AnimationCurve curve, float topHeight, float distance)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
