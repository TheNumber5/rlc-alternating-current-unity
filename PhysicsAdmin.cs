using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsAdmin : MonoBehaviour {
	public static PhysicsAdmin instance;
	public DataInput dataInput;
	public RLCSeriesParallel rlcSeries;
	void Start() {
		if(instance==null) {
			instance = this;
			dataInput.ChangeInputType();
		}
	}
	public void StartPhysics() {
		dataInput.SetData();
		rlcSeries.ExecuteProgram();
		dataInput.PrintData();
		Debug.Log("Executed main program function.");
	}
	public void ShowHideDataUI() {
		dataInput.ShowHideDataUI();
	}
	public void ResetData() {
		rlcSeries.ResetData();
		dataInput.ResetPrint();
	}
	public void Return() {
		dataInput.ReturnData();
	}
}