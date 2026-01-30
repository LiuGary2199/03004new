using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class UnionDoubtful : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Sweden{ get { return Appear; } set { Appear = value; } }

	[SerializeField] private Sprite[] Appear= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Skyrocket{ get { return Oscillate; } set { Oscillate = value; } }

	[SerializeField] private float Oscillate= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool ThwartTiltIrony{ get { return SaharaTiltIrony; } set { SaharaTiltIrony = value; } }

	[SerializeField] private bool SaharaTiltIrony= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Whig{ get { return Cone; } set { Cone = value; } }

	[SerializeField] private bool Cone= true;

	//动画曲线
	[SerializeField] private AnimationCurve Rocky= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Train;
	//目标SpriteRenderer组件
	private SpriteRenderer GeniusMobilize;
	//当前帧索引
	private int PolluteUnionAngry= 0;
	//下一次更新时间
	private float Upset= 0.0f;
	//当前帧率，通过曲线计算而来
	private float PolluteSkyrocket= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void Loder()
	{
		PolluteUnionAngry = Oscillate < 0 ? Appear.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Lion()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Offer()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Rime()
	{
		Offer();
		Loder();
	}

	//自动开启动画
	void Start()
	{
		Train = this.GetComponent<Image>();
		GeniusMobilize = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Train == null && GeniusMobilize == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Appear == null || Appear.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Rocky.Evaluate((float)PolluteUnionAngry / Appear.Length);
			float curvedFramerate = curveValue * Oscillate;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float time = SaharaTiltIrony ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (time - Upset > interval)
				{
					//执行更新操作
					GoSnugly();
				}
			}
#if UNITY_EDITOR
			else
			{
				Debug.LogWarning("Framerate got '0' value, animation stopped.");
			}
#endif
		}
	}

	//具体更新操作
	private void GoSnugly()
	{
		//计算新的索引
		int nextIndex = PolluteUnionAngry + (int)Mathf.Sign(PolluteSkyrocket);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Appear.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Cone == false)
			{
				PolluteUnionAngry = Mathf.Clamp(PolluteUnionAngry, 0, Appear.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		PolluteUnionAngry = nextIndex % Appear.Length;
		//更新图片
		if (Train != null)
		{
			Train.sprite = Appear[PolluteUnionAngry];
		}
		else if (GeniusMobilize != null)
		{
			GeniusMobilize.sprite = Appear[PolluteUnionAngry];
		}
		//设置计时器为当前时间
		Upset = SaharaTiltIrony ? Time.unscaledTime : Time.time;
	}
}

