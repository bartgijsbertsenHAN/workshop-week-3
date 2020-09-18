using UnityEngine;
using System.Collections;
using System.Threading;
using System;

public class StateController : MonoBehaviour {
	static float TIME = 2f;
	private float timedStateChange = TIME;
	private Context context;
	private enum CurrentState {start,stop};
	private CurrentState myState = CurrentState.start;

	// Use this for initialization
	void Start () {
		this.context = new Context ();
	}

	// Update is called once per frame
	void Update () {
		changeState ();
	}

	void changeState() {
		timedStateChange -= Time.deltaTime;

		if (timedStateChange <= 0) {
			//start event
			if (myState == CurrentState.start) {
				StopState stopState = new StopState ();
				stopState.doAction (context);
				Debug.Log(context.getState().ToString());
				timedStateChange = TIME;
				myState = CurrentState.stop;

			} else {
				StartState startState = new StartState ();
				startState.doAction (context);
				Debug.Log(context.getState().ToString());
				timedStateChange = TIME;
				myState = CurrentState.start;
			}
		}
	}

}
