using UnityEngine;

public class DestroyAnimals : MonoBehaviour
{
	[SerializeField]
	private int posZToDestroy;

	private void Update()
	{
		Transform life = transform.parent.GetComponent<GestionnaireJeu>().lifeCounter.transform;

		if (life.GetComponent<LifeCounter>().life == 0)
		{
			Destroy(gameObject);
			return;
		}
		
		if (transform.position.z <= posZToDestroy)
		{
			if (life.GetComponent<LifeCounter>().life > 0)
				life.GetComponent<LifeCounter>().life--;
			life.GetChild(life.GetComponent<LifeCounter>().life).gameObject.SetActive(false);
			Destroy(gameObject);
		}
	}
	
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
		{
			Destroy(gameObject);
			Destroy(collision.gameObject);
			transform.parent.GetComponent<GestionnaireJeu>().scoreCounter.score++;
		}
	}
}