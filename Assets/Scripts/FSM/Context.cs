using UnityEngine;
using System.Collections;
using UnityEditorInternal;

public class Context  {

	private IState state;

	public Transform player;

	public Transform self;

	public Context() {
		state = null;
		self = gameObject.GetComponent<Transform>();
	}
	public void setState(IState state) {
		this.state = state;
	}

	public IState getState() {
		return state;
	}
}
