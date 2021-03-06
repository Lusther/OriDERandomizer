using System;
using UnityEngine;

// Token: 0x02000298 RID: 664
public class Damage
{
	// Token: 0x06000CD9 RID: 3289
	public Damage(float amount, Vector2 force, Vector3 position, DamageType type, GameObject sender)
	{
		this.m_amount = amount;
		this.m_force = force;
		this.m_position = position;
		this.m_type = type;
		this.m_sender = sender;
		if (type == DamageType.SpiritFlame)
		{
			this.m_amount += (float)RandomizerBonus.SpiritFlameLevel();
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0000B8CE File Offset: 0x00009ACE
	public float Amount
	{
		get
		{
			return this.m_amount;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0000B8D6 File Offset: 0x00009AD6
	public Vector2 Force
	{
		get
		{
			return this.m_force;
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0000B8DE File Offset: 0x00009ADE
	public Vector3 Position
	{
		get
		{
			return this.m_position;
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0000B8E6 File Offset: 0x00009AE6
	public DamageType Type
	{
		get
		{
			return this.m_type;
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0000B8EE File Offset: 0x00009AEE
	public GameObject Sender
	{
		get
		{
			return this.m_sender;
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0000B8F6 File Offset: 0x00009AF6
	public void SetAmount(float amount)
	{
		this.m_amount = amount;
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0000B8FF File Offset: 0x00009AFF
	public void DealToComponents(GameObject target)
	{
		if (target != null)
		{
			target.SendMessage("OnRecieveDamage", this, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x04000C2C RID: 3116
	private float m_amount;

	// Token: 0x04000C2D RID: 3117
	private Vector2 m_force;

	// Token: 0x04000C2E RID: 3118
	private Vector3 m_position;

	// Token: 0x04000C2F RID: 3119
	private DamageType m_type;

	// Token: 0x04000C30 RID: 3120
	private GameObject m_sender;
}
