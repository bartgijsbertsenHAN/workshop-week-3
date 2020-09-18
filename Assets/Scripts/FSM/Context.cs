using UnityEngine;
using System.Collections;
using UnityEditorInternal;

public class Context  {

	private IState state;

	public Context() {
		state = null;
	}
	public void setState(IState state) {
		this.state = state;
	}

	public IState getState() {
		return state;
	}
}
