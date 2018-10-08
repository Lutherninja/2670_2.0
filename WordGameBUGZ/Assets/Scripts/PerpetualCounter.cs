using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PerpetualCounter : MonoBehaviour
{

	public UnityEvent OnCount;
	public float Seconds;

	IEnumerator Start()
	{
		while (true)
		{
			OnCount.Invoke();
			yield return new WaitForSeconds(Seconds);
		}
	}
}
