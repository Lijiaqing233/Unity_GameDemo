﻿using UnityEngine;
using System.Collections;

public class BurnHelper_play : MonoBehaviour
{

	public Material material;

	[Range(0.01f, 1.0f)]
	public float burnSpeed = 0.3f;
	[SerializeField]
	private PlayerData playerData;
	private float burnAmount = 0.0f;

	// Use this for initialization
	void Start()
	{
		playerData = GetComponent<PlayerData>();
		if (material == null)
		{
			Renderer renderer = gameObject.GetComponent<Renderer>();
			if (renderer != null)
			{
				material = renderer.material;
			}
		}

		if (material == null)
		{
			this.enabled = false;
		}
		else
		{
			material.SetFloat("_BurnAmount", 0.0f);
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (playerData.HP <= 0 & burnAmount < 1)
		{
			burnAmount += burnSpeed * Time.deltaTime;
		}
		//burnAmount = 1;
		material.SetFloat("_BurnAmount", burnAmount);
	}
}
