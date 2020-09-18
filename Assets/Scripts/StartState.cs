using UnityEngine;
using System.Collections;
using System;

public class StartState : IState {
	public void doAction(Context context) {
		Debug.Log ("Player is in StartState"); 
		context.setState (this);
	}

	String toString() {
		return "Start State";
	}
}
