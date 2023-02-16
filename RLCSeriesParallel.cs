using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLCSeriesParallel : MonoBehaviour {
	public string typeOfCircuit;
	public double I, Imax, U, Umax, Ur, Ucoil, Ucap, UC, UL, Z, XC, XL, R, omega, mu, T, phi, cosPhi, L, C, P, Pr, Pa, muRez, resonanceOmega, Irez, Q;
	[HideInInspector]
	public bool IKnown, ImaxKnown, UKnown, UmaxKnown, UrKnown, UcoilKnown, UcapKnown, UCKnown, ULKnown, ZKnown, XCKnown, XLKnown, RKnown, omegaKnown, muKnown, TKnown, phiKnown, cosPhiKnown, LKnown, CKnown, PKnown, PrKnown, PaKnown, muRezKnown, resonanceOmegaKnown, IrezKnown, QKnown;
	public bool IKnownData, ImaxKnownData, UKnownData, UmaxKnownData, UrKnownData, UcoilKnownData, UcapKnownData, UCKnownData, ULKnownData, ZKnownData, XCKnownData, XLKnownData, RKnownData, omegaKnownData, muKnownData, TKnownData, phiKnownData, cosPhiKnownData, LKnownData, CKnownData, PKnownData, PrKnownData, PaKnownData, muRezKnownData, resonanceOmegaKnownData, IrezKnownData, QKnownData;
	private int executionIterations=10;
	[ContextMenu("Execute RLC series calculation.")]
	public void ExecuteProgram() {
		SetKnownFromData();
		for(int i=0; i<executionIterations; i++) {
		//This looks very bad but it's easier to read than an array-based method and it's not extremely inefficient.
		if(!IKnown&&UKnown&&ZKnown) {
			I = U/Z;
			IKnown = true;
		}
		if(!ZKnown&&IKnown&&UKnown) {
			Z = U/I;
			ZKnown = true;
		}
		if(!UKnown&&IKnown&&ZKnown) {
			U = I*Z;
			UKnown = true;
		}
		if(!ZKnown&&RKnown&&XLKnown&&XCKnown&&typeOfCircuit=="RLC") {
			Z = System.Math.Sqrt(R*R+System.Math.Pow(XL-XC,2));
			ZKnown = true;
		}
		if(!ZKnown&&XLKnown&&typeOfCircuit=="L") {
			Z = XL;
			ZKnown = true;
		}
		if(!ZKnown&&XCKnown&&typeOfCircuit=="C") {
			Z = XC;
			ZKnown = true;
		}
		if(!XLKnown&&ZKnown&&typeOfCircuit=="L") {
			XL = Z;
			XLKnown = true;
		}
		if(!XCKnown&&ZKnown&&typeOfCircuit=="C") {
			XC = Z;
			XCKnown = true;
		}
		if(!ZKnown&&RKnown&&XLKnown&&typeOfCircuit=="RL") {
			Z = System.Math.Sqrt(R*R+XL*XL);
			ZKnown = true;
		}
		if(!ZKnown&&RKnown&&XCKnown&&typeOfCircuit=="RC") {
			Z = System.Math.Sqrt(R*R+XC*XC);
			ZKnown = true;
		}
		if(!UcoilKnown&&UrKnown&&ULKnown) {
			Ucoil = System.Math.Sqrt(Ur*Ur+UL*UL);
			UcoilKnown = true;
		}
		if(!UcapKnown&&UrKnown&&UCKnown) {
			Ucap = System.Math.Sqrt(Ur*Ur+UC*UC);
			UcapKnown = true;
		}
		if(!ZKnown&&RKnown&&typeOfCircuit=="R") {
			Z = R;
			ZKnown = true;
		}
		if(!RKnown&&UrKnown&&IKnown) {
			R = Ur/I;
			RKnown = true;
		}
		if(!LKnown&&XLKnown&&omegaKnown) {
			L = XL/omega;
			LKnown = true;
		}
		if(!CKnown&&XCKnown&&omegaKnown) {
			C = 1/(omega*XC);
			CKnown = true;
		}
		if(!UKnown&&IKnown&&ZKnown) {
			U = I*Z;
			UKnown = true;
		}
		if(!UrKnown&&RKnown&&IKnown) {
			Ur = I*R;
			UrKnown = true;
		}
		if(!RKnown&&IKnown&&UrKnown) {
			R = U/I;
			RKnown = true;
		}
		if(!UmaxKnown&&UKnown) {
			Umax = U*System.Math.Sqrt(2);
			UmaxKnown = true;
		}
		if(!UKnown&&UmaxKnown) {
			U = Umax/System.Math.Sqrt(2);
			UKnown = true;
		}
		if(!ImaxKnown&&IKnown) {
			Imax = I*System.Math.Sqrt(2);
			ImaxKnown = true;
		}
		if(!IKnown&&ImaxKnown) {
			I = Imax/System.Math.Sqrt(2);
			IKnown = true;
		}
		if(!IKnown&&ULKnown&&XLKnown) {
			I = UL/XL;
			IKnown = true;
		}
		if(!IKnown&&UCKnown&&XCKnown) {
			I = UC/XC;
			IKnown = true;
		}
		if(!TKnown&&muKnown) {
			T = 1/mu;
			TKnown = true;
		}
		if(!muKnown&&TKnown) {
			mu = 1/T;
			muKnown = true;
		}
		if(!omegaKnown&&muKnown) {
			omega = 2*System.Math.PI*mu;
			omegaKnown = true;
		}
		if(!XLKnown&&ULKnown&&IKnown) {
			XL = UL/I;
			XLKnown = true;
		}
		if(!XCKnown&&UCKnown&&IKnown) {
			XC = UC/I;
			XCKnown = true;
		}
		if(!XLKnown&&omegaKnown&&LKnown) {
			XL = omega*L;
			XLKnown = true;
		}
		if(!XCKnown&&omegaKnown&&CKnown) {
			XC = 1/(omega*C);
			XCKnown = true;
		}
		if(!phiKnown&&XCKnown&&XLKnown&&RKnown&&typeOfCircuit=="RLC") {
			phi = System.Math.Atan((XL-XC)/R);
			phiKnown = true;
		}
		if(!phiKnown&&XLKnown&&RKnown&&typeOfCircuit=="RL") {
			phi = System.Math.Atan((XL)/R);
			phiKnown = true;
		}
		if(!phiKnown&&XCKnown&&RKnown&&typeOfCircuit=="RC") {
			phi = System.Math.Atan((-XC)/R);
			phiKnown = true;
		}
		if(!UrKnown&&UKnown&&phiKnown) {
			Ur = U*System.Math.Cos(phi);
			UrKnown = true;
		}
		if(!UKnown&&UCKnown&&ULKnown&&phiKnown&&typeOfCircuit=="RLC") {
			U = (UC-UL)/System.Math.Sin(phi);
		}
		if(!ULKnown&&UKnown&&phiKnown&&typeOfCircuit=="RL") {
			UL = U*System.Math.Sin(phi);
			ULKnown = true;
		}
		if(!UCKnown&&UKnown&&phiKnown&&typeOfCircuit=="RC") {
			UC = U*System.Math.Sin(phi);
			UCKnown = true;
		}
		if(!PKnown&&IKnown&&RKnown) {
			P = R*I*I;
			PKnown = true;
		}
		if(!PrKnown&&IKnown&&XLKnown&&XCKnown&&typeOfCircuit=="RLC") {
			Pr = I*I*(XL-XC);
			PrKnown = true;
		}
		if(!PrKnown&&IKnown&&XLKnown&&(typeOfCircuit=="RL"||typeOfCircuit=="L")) {
			Pr = I*I*XL;
			PrKnown = true;
		}
		if(!PrKnown&&IKnown&&XCKnown&&(typeOfCircuit=="RC"||typeOfCircuit=="C")) {
			Pr = -I*I*XC;
			PrKnown = true;
		}
		if(!PaKnown&&IKnown&&UKnown) {
			Pa = U*I;
			PaKnown = true;
		}
		if(!muRezKnown&&LKnown&&CKnown) {
			muRez = 1/(2*System.Math.PI*System.Math.Sqrt(L*C));
			muRezKnown = true;
		}
		if(!resonanceOmegaKnown&&LKnown&&CKnown) {
			resonanceOmega = 1/(System.Math.Sqrt(L*C));
			resonanceOmegaKnown = true;
		}
		if(!muKnown&&omegaKnown) {
			mu = omega/(2*System.Math.PI);
			muKnown = true;
		}
		if(!IrezKnown&&UKnown&&RKnown&&typeOfCircuit=="RLC") {
			Irez = U/R;
			IrezKnown = true;
		}
		if(!QKnown&&RKnown&&LKnown&&CKnown) {
			Q = 1/R*System.Math.Sqrt(L/C);
			QKnown = true;
		}
		if(!UCKnown&&IKnown&&XCKnown) {
			UC = I*XC;
			UCKnown = true;
		}
		if(!ULKnown&&IKnown&&XLKnown) {
			UL = I*XL;
			ULKnown = true;
		}
		if(!cosPhiKnown&&phiKnown) {
			cosPhi = System.Math.Cos(phi);
			cosPhiKnown = true;
		}
		if(!cosPhiKnown&&PKnown&&UKnown&&IKnown) {
			cosPhi = P/(U*I);
			cosPhiKnown = true;
		}
	}
	Debug.Log("Executed RLC series calculation.");
	}
	[ContextMenu("Reset all data.")]
	public void ResetData() {
		IKnown = false;
		ImaxKnown = false;
		UKnown = false;
		UmaxKnown = false;
		UrKnown = false;
		UcoilKnown = false;
		UcapKnown = false;
		UCKnown = false;
		ULKnown = false;
		ZKnown = false;
		XCKnown = false;
		XLKnown = false;
		RKnown = false;
		omegaKnown = false;
		muKnown = false;
		TKnown = false;
		phiKnown = false;
		cosPhiKnown = false;
		LKnown = false;
		CKnown = false;
		PKnown = false;
		PaKnown = false;
		PrKnown = false;
		muRezKnown = false;
		resonanceOmegaKnown = false;
		IrezKnown = false;
		QKnown = false;
		IKnownData = false;
		ImaxKnownData = false;
		UKnownData = false;
		UmaxKnownData = false;
		UrKnownData = false;
		UcoilKnownData = false;
		UcapKnownData = false;
		UCKnownData = false;
		ULKnownData = false;
		ZKnownData = false;
		XCKnownData = false;
		XLKnownData = false;
		RKnownData = false;
		omegaKnownData = false;
		muKnownData = false;
		TKnownData = false;
		phiKnownData = false;
		cosPhiKnownData = false;
		LKnownData = false;
		CKnownData = false;
		PKnownData = false;
		PaKnownData = false;
		PrKnownData = false;
		muRezKnownData = false;
		resonanceOmegaKnownData = false;
		IrezKnownData = false;
		QKnownData = false;
	}
	public void SetKnownFromData() {
		//This also looks terrible but it works.
		if(IKnownData) {
			IKnown = true;
		}
		if(ImaxKnownData) {
			ImaxKnown = true;
		}
		if(UKnownData) {
			UKnown = true;
		}
		if(UmaxKnownData) {
			UmaxKnown = true;
		}
		if(UrKnownData) {
			UrKnown = true;
		}
		if(UcoilKnownData) {
			UcoilKnown = true;
		}
		if(UcapKnownData) {
			UcapKnown = true;
		}
		if(UCKnownData) {
			UCKnown = true;
		}
		if(ULKnownData) {
			ULKnown = true;
		}
		if(ZKnownData) {
			ZKnown = true;
		}
		if(XCKnownData) {
			XCKnown = true;
		}
		if(XLKnownData) {
			XLKnown= true;
		}
		if(RKnownData) {
			RKnown = true;
		}
		if(omegaKnownData) {
			omegaKnown = true;
		}
		if(muKnownData) {
			muKnown = true;
		}
		if(TKnownData) {
			TKnown = true;
		}
		if(phiKnownData) {
			phiKnown = true;
		}
		if(cosPhiKnownData) {
			cosPhiKnown = true;
		}
		if(LKnownData) {
			LKnown = true;
		}
		if(CKnownData) {
			CKnown = true;
		}
		if(PKnownData) {
			PKnown = true;
		}
		if(PrKnownData) {
			PrKnown = true;
		}
		if(PaKnownData) {
			PaKnown = true;
		}
		if(muRezKnownData) {
			muRezKnown = true;
		}
		if(resonanceOmegaKnownData) {
			resonanceOmegaKnown = true;
		}
		if(IrezKnownData) {
			IrezKnown = true;
		}
		if(QKnownData) {
			QKnown = true;
		}
		Debug.Log("Set known from data.");
	}
}