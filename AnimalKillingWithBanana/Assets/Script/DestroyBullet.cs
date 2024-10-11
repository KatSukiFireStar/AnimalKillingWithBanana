using System;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
	[SerializeField]
	private int posZToDestroy;
	
	private GameObject bullet;

	private void Start()
	{
		bullet = transform.parent.gameObject;
	}

	private void Update()
	{
		if (bullet.GetComponent<LifeHolder>().lifeCounter.life == 0)
		{
			Destroy(gameObject);
			return;
		}
		
		if (transform.position.z >= posZToDestroy)
		{
			Destroy(gameObject);
		}
	}

	
}