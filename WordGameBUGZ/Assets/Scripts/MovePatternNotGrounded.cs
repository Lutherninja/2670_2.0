﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

[CreateAssetMenu(fileName = "MovePatternNotGrounded")]
public class MovePatternNotGrounded : MovePattern {

	public override void Invoke(CharacterController controller, Transform transform)
	{
		Move(transform);
		Move(controller);
	}
}
