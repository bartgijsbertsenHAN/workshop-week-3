using UnityEngine;
using System.Collections;

public class StopState : IState {

	public void doAction(Context context) {
		Debug.Log ("Player is in StopState"); 
		context.setState(this);
	}

	string toString() {
		return "Stop State";
	}
}
