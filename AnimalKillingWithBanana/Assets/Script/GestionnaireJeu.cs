using System;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
	[SerializeField] 
	private List<GameObject> animals = new();

	[SerializeField] 
	private float timeBetweenSpawns;
	
	public ScoreCounter scoreCounter;
	public LifeCounter lifeCounter;
	
	[HideInInspector]
	public bool gameOver = false;

	private void Awake()
	{
		InvokeRepeating("SpawnAnimals", 0f, timeBetweenSpawns);
	}

	private void SpawnAnimals()
	{
		if (gameOver)
			return;
		
		GameObject animal = animals[UnityEngine.Random.Range(0, animals.Count)];
		CreateAnimal(animal, new(UnityEngine.Random.Range(-11, 11), transform.position.y, transform.position.z), animal.transform.rotation);
	}

	private void CreateAnimal(GameObject animal, Vector3 position, Quaternion rotation)
	{
		Instantiate(animal, position, rotation, gameObject.transform);
	}
}