using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
//Made By Jonathan Luther
public class InstanceObject :ScriptableObject
{

	public void Call(GameObject instance)
	{
		Instantiate(instance);
	}
}
