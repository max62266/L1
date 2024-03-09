﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

public float value = 100;
public RectTransform valueRectTransform;
public GameObject gameplayUI;
public GameObject gamepOverScreen;
public Animator animator;
private float _maxValue;

private void Start()
{
_maxValue = value;
DrawHealthBar();
}
public void DealDamage(float damage)
{
	value -= damage;
	if (value <= 0)
	{
	PlayerIsdead();
	}
	DrawHealthBar ();
}
public void AddHealth(float amount)
{
value += amount;
value = Mathf.Clamp(value,0,_maxValue);
DrawHealthBar();
}
private void PlayerIsdead()
{
        gameplayUI.SetActive(false);
		gamepOverScreen.SetActive(true);
		gamepOverScreen.GetComponent<Animator>().SetTrigger("Show");
		GetComponent<PlayerController>().enabled = false;
		GetComponent<FireballCaster>().enabled = false;
		GetComponent<CameraRotation>().enabled = false;
		animator.SetTrigger("Death");
}
private void DrawHealthBar()
{
	valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
}

}
