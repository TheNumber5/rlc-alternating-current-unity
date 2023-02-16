using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataInput : MonoBehaviour {
	public RLCSeriesParallel rlcSeries;
	public TMP_Dropdown selectionDropdown;
	public GameObject R_UI, C_UI, L_UI, RL_UI, RC_UI, RLC_UI;
	private GameObject currentUI;
	public TMP_InputField I, Imax, U, Umax, Ur, Ucoil, Ucap, UC, UL, Z, XC, XL, R, omega, mu, T, phi, cosPhi, L, C, P, Pr, Pa, muRez, resonanceOmega, Irez, Q;
	public TMP_Dropdown Id, Imaxd, Ud, Umaxd, Urd, Ucoild, Ucapd, UCd, ULd, Zd, XCd, XLd, Rd, omegad, mud, Td, phid, Ld, Cd, Pd, Prd, Pad, muRezd, resonanceOmegad, Irezd;
	public TMP_Text It, Imaxt, Ut, Umaxt, Urt, Ucoilt, Ucapt, UCt, ULt, Zt, XCt, XLt, Rt, omegat, mut, Tt, phit, cosPhit, Lt, Ct, Pt, Prt, Pat, muRezt, resonanceOmegat, Irezt, Qt;
	public GameObject inputs, outputs;
	public GameObject RLCGraphics, RGraphics, LGraphics, CGraphics, RCGraphics, RLGraphics;
	void Start() {
		currentUI = RLC_UI;
	}
	[ContextMenu("Set data to scripts.")]
	public void SetData() {
		//This also looks very stupid but it still works.
		double parsed;
		if(double.TryParse(I.text, out parsed)) {
		rlcSeries.I = (parsed*Mathf.Pow(10, 9-3*Id.value));
		rlcSeries.IKnownData = true;
		}
		if(double.TryParse(Imax.text, out parsed)) {
		rlcSeries.Imax = (parsed*Mathf.Pow(10, 9-3*Imaxd.value));
		rlcSeries.ImaxKnownData = true;
		}
		if(double.TryParse(U.text, out parsed)) {
		rlcSeries.U = (parsed*Mathf.Pow(10, 9-3*Ud.value));
		rlcSeries.UKnownData = true;
		}
		if(double.TryParse(Umax.text, out parsed)) {
		rlcSeries.Umax = (parsed*Mathf.Pow(10, 9-3*Umaxd.value));
		rlcSeries.UmaxKnownData = true;
		}
		if(double.TryParse(Ur.text, out parsed)) {
		rlcSeries.Ur = (parsed*Mathf.Pow(10, 9-3*Urd.value));
		rlcSeries.UrKnownData = true;
		}
		if(double.TryParse(Ucoil.text, out parsed)) {
		rlcSeries.Ucoil = (parsed*Mathf.Pow(10, 9-3*Ucoild.value));
		rlcSeries.UcoilKnownData = true;
		}
		if(double.TryParse(Ucap.text, out parsed)) {
		rlcSeries.Ucap = (parsed*Mathf.Pow(10, 9-3*Ucapd.value));
		rlcSeries.UcapKnownData = true;
		}
		if(double.TryParse(UC.text, out parsed)) {
		rlcSeries.UC = (parsed*Mathf.Pow(10, 9-3*UCd.value));
		rlcSeries.UCKnownData = true;
		}
		if(double.TryParse(UL.text, out parsed)) {
		rlcSeries.UL = (parsed*Mathf.Pow(10, 9-3*ULd.value));
		rlcSeries.ULKnownData = true;
		}
		if(double.TryParse(Z.text, out parsed)) {
		rlcSeries.Z = (parsed*Mathf.Pow(10, 9-3*Zd.value));
		rlcSeries.ZKnownData = true;
		}
		if(double.TryParse(XC.text, out parsed)) {
		rlcSeries.XC = (parsed*Mathf.Pow(10, 9-3*XCd.value));
		rlcSeries.XCKnownData = true;
		}
		if(double.TryParse(XL.text, out parsed)) {
		rlcSeries.XL = (parsed*Mathf.Pow(10, 9-3*XLd.value));
		rlcSeries.XLKnownData = true;
		}
		if(double.TryParse(R.text, out parsed)) {
		rlcSeries.R = (parsed*Mathf.Pow(10, 9-3*Rd.value));
		rlcSeries.RKnownData = true;
		}
		if(double.TryParse(omega.text, out parsed)) {
		rlcSeries.omega = (parsed*Mathf.Pow(10, 9-3*omegad.value));
		rlcSeries.omegaKnownData = true;
		}
		if(double.TryParse(mu.text, out parsed)) {
		rlcSeries.mu = (parsed*Mathf.Pow(10, 9-3*mud.value));
		rlcSeries.muKnownData = true;
		}
		if(double.TryParse(T.text, out parsed)) {
		rlcSeries.T = (parsed*Mathf.Pow(10, 9-3*Td.value));
		rlcSeries.TKnownData = true;
		}
		if(double.TryParse(phi.text, out parsed)) {
		rlcSeries.phi = (parsed*Mathf.Pow(10, 9-3*phid.value));
		rlcSeries.phiKnownData = true;
		}
		if(double.TryParse(cosPhi.text, out parsed)) {
		rlcSeries.cosPhi = parsed;
		rlcSeries.cosPhiKnownData = true;
		}
		if(double.TryParse(L.text, out parsed)) {
		rlcSeries.L = (parsed*Mathf.Pow(10, 9-3*Ld.value));
		rlcSeries.LKnownData = true;
		}
		if(double.TryParse(C.text, out parsed)) {
		rlcSeries.C = (parsed*Mathf.Pow(10, 9-3*Cd.value));
		rlcSeries.CKnownData = true;
		}
		if(double.TryParse(P.text, out parsed)) {
		rlcSeries.P = (parsed*Mathf.Pow(10, 9-3*Pd.value));
		rlcSeries.PKnownData = true;
		}
		if(double.TryParse(Pa.text, out parsed)) {
		rlcSeries.Pa = (parsed*Mathf.Pow(10, 9-3*Pad.value));
		rlcSeries.PaKnownData = true;
		}
		if(double.TryParse(Pr.text, out parsed)) {
		rlcSeries.Pr = (parsed*Mathf.Pow(10, 9-3*Prd.value));
		rlcSeries.PrKnownData = true;
		}
		if(double.TryParse(muRez.text, out parsed)) {
		rlcSeries.muRez = (parsed*Mathf.Pow(10, 9-3*muRezd.value));
		rlcSeries.muRezKnownData = true;
		}
		if(double.TryParse(resonanceOmega.text, out parsed)) {
		rlcSeries.resonanceOmega = (parsed*Mathf.Pow(10, 9-3*resonanceOmegad.value));
		rlcSeries.resonanceOmegaKnownData = true;
		}
		if(double.TryParse(Irez.text, out parsed)) {
		rlcSeries.Irez = (parsed*Mathf.Pow(10, 9-3*Irezd.value));
		rlcSeries.IrezKnownData = true;
		}
		if(double.TryParse(Q.text, out parsed)) {
		rlcSeries.Q = parsed;
		rlcSeries.QKnownData = true;
		}
	}
	[ContextMenu("Print data and make inputs invisible.")]
	public void PrintData() {
		inputs.SetActive(false);
		outputs.SetActive(true);
		if(rlcSeries.IKnown) {
			It.text = ScientificNotation(rlcSeries.I, "A");
		}
		if(rlcSeries.ImaxKnown) {
			Imaxt.text = ScientificNotation(rlcSeries.Imax, "A");
		}
		if(rlcSeries.UKnown) {
			Ut.text = ScientificNotation(rlcSeries.U, "V");
		}
		if(rlcSeries.UmaxKnown) {
			Umaxt.text = ScientificNotation(rlcSeries.Umax, "V");
		}
		if(rlcSeries.UrKnown) {
			Urt.text = ScientificNotation(rlcSeries.Ur, "V");
		}
		if(rlcSeries.UcoilKnown) {
			Ucoilt.text = ScientificNotation(rlcSeries.Ucoil, "V");
		}
		if(rlcSeries.UcapKnown) {
			Ucapt.text = ScientificNotation(rlcSeries.Ucap, "V");
		}
		if(rlcSeries.UCKnown) {
			UCt.text = ScientificNotation(rlcSeries.UC, "V");
		}
		if(rlcSeries.ULKnown) {
			ULt.text = ScientificNotation(rlcSeries.UL, "V");
		}
		if(rlcSeries.ZKnown) {
			Zt.text = ScientificNotation(rlcSeries.Z, "Ω");
		}
		if(rlcSeries.XCKnown) {
			XCt.text = ScientificNotation(rlcSeries.XC, "Ω");
		}
		if(rlcSeries.XLKnown) {
			XLt.text = ScientificNotation(rlcSeries.XL, "Ω");
		}
		if(rlcSeries.RKnown) {
			Rt.text = ScientificNotation(rlcSeries.R, "Ω");
		}
		if(rlcSeries.omegaKnown) {
			omegat.text = ScientificNotation(rlcSeries.omega, "rad/s");
		}
		if(rlcSeries.muKnown) {
			mut.text = ScientificNotation(rlcSeries.mu, "Hz");
		}
		if(rlcSeries.TKnown) {
			Tt.text = ScientificNotation(rlcSeries.T, "s");
		}
		if(rlcSeries.phiKnown) {
			phit.text = rlcSeries.phi.ToString("0.000");
		}
		if(rlcSeries.cosPhiKnown) {
			cosPhit.text = rlcSeries.cosPhi.ToString("0.000");
		}
		if(rlcSeries.LKnown) {
			Lt.text = ScientificNotation(rlcSeries.L, "H");
		}
		if(rlcSeries.CKnown) {
			Ct.text = ScientificNotation(rlcSeries.C, "F");
		}
		if(rlcSeries.PKnown) {
			Pt.text = ScientificNotation(rlcSeries.P, "W");
		}
		if(rlcSeries.PaKnown) {
			Pat.text = ScientificNotation(rlcSeries.Pa, "VA");
		}
		if(rlcSeries.PrKnown) {
			Prt.text = ScientificNotation(System.Math.Abs(rlcSeries.Pr), "VAR");
		}
		if(rlcSeries.muRezKnown) {
			muRezt.text = ScientificNotation(rlcSeries.muRez, "Hz");
		}
		if(rlcSeries.resonanceOmegaKnown) {
			resonanceOmegat.text = ScientificNotation(rlcSeries.resonanceOmega, "rad/s");
		}
		if(rlcSeries.IrezKnown) {
			Irezt.text = ScientificNotation(rlcSeries.Irez, "A");
		}
		if(rlcSeries.QKnown) {
			Qt.text = rlcSeries.Q.ToString("0.000");
		}
	}
	[ContextMenu("Reset all outputted information.")]
	public void ResetPrint() {
		outputs.SetActive(false);
		inputs.SetActive(true);
		It.text = "";
		Imaxt.text = "";
		Ut.text = "";
		Umaxt.text = "";
		Urt.text = "";
		Ucoilt.text = "";
		Ucapt.text = "";
		UCt.text = "";
		ULt.text = "";
		Zt.text = "";
		XCt.text = "";
		XLt.text = "";
		Rt.text = "";
		omegat.text = "";
		mut.text = "";
		Tt.text = "";
		phit.text = "";
		cosPhit.text = "";
		Lt.text = "";
		Ct.text = "";
		Pt.text = "";
		Pat.text = "";
		Prt.text = "";
		muRezt.text = "";
		resonanceOmegat.text = "";
		Irezt.text = "";
		Qt.text = "";
	}
	[ContextMenu("Return all input data to null.")]
	public void ReturnData() {
		I.text = "";
		Imax.text = "";
		U.text = "";
		Umax.text = "";
		Ur.text = "";
		Ucoil.text = "";
		Ucap.text = "";
		UC.text = "";
		UL.text = "";
		Z.text = "";
		XC.text = "";
		XL.text = "";
		R.text = "";
		omega.text = "";
		mu.text = "";
		T.text = "";
		phi.text = "";
		cosPhi.text = "";
		L.text = "";
		C.text = "";
		P.text = "";
		Pa.text = "";
		Pr.text = "";
		muRez.text = "";
		resonanceOmega.text = "";
		Irez.text = "";
		Q.text = "";
	}
	public void ChangeInputType() {
		HideAllCircuitGraphics();
		if(selectionDropdown.value==0) {
			rlcSeries.typeOfCircuit = "R";
			RGraphics.SetActive(true);
			R_UI.SetActive(true);
			C_UI.SetActive(false);
			L_UI.SetActive(false);
			RL_UI.SetActive(false);
			RC_UI.SetActive(false);
			RLC_UI.SetActive(false);
			currentUI = R_UI;
			inputs = currentUI.transform.GetChild(0).gameObject;
			outputs = currentUI.transform.GetChild(1).gameObject;
			I = currentUI.transform.Find("Inputs/Intensity input field").GetComponent<TMP_InputField>();
			Imax = currentUI.transform.Find("Inputs/Maximum intensity input field").GetComponent<TMP_InputField>();
			U = currentUI.transform.Find("Inputs/Voltage input field").GetComponent<TMP_InputField>();
			Umax = currentUI.transform.Find("Inputs/Maximum voltage input field").GetComponent<TMP_InputField>();
			Ur = currentUI.transform.Find("Inputs/Resistor voltage input field").GetComponent<TMP_InputField>();
			R = currentUI.transform.Find("Inputs/Resistance input field").GetComponent<TMP_InputField>();
			omega = currentUI.transform.Find("Inputs/Pulsation input field").GetComponent<TMP_InputField>();
			mu = currentUI.transform.Find("Inputs/Frequency input field").GetComponent<TMP_InputField>();
			T = currentUI.transform.Find("Inputs/Period input field").GetComponent<TMP_InputField>();
			P = currentUI.transform.Find("Inputs/Active power input field").GetComponent<TMP_InputField>();

			Id = currentUI.transform.Find("Inputs/Intensity dropdown").GetComponent<TMP_Dropdown>();
			Imaxd = currentUI.transform.Find("Inputs/Maximum intensity dropdown").GetComponent<TMP_Dropdown>();
			Ud = currentUI.transform.Find("Inputs/Voltage dropdown").GetComponent<TMP_Dropdown>();
			Umaxd = currentUI.transform.Find("Inputs/Maximum voltage dropdown").GetComponent<TMP_Dropdown>();
			Urd = currentUI.transform.Find("Inputs/Resistor voltage dropdown").GetComponent<TMP_Dropdown>();
			Rd = currentUI.transform.Find("Inputs/Resistance dropdown").GetComponent<TMP_Dropdown>();
			omegad = currentUI.transform.Find("Inputs/Pulsation dropdown").GetComponent<TMP_Dropdown>();
			mud = currentUI.transform.Find("Inputs/Frequency dropdown").GetComponent<TMP_Dropdown>();
			Td = currentUI.transform.Find("Inputs/Period dropdown").GetComponent<TMP_Dropdown>();
			Pd = currentUI.transform.Find("Inputs/Active power dropdown").GetComponent<TMP_Dropdown>();
			
			It = currentUI.transform.Find("Outputs/I output").GetComponent<TMP_Text>();
			Imaxt = currentUI.transform.Find("Outputs/Imax output").GetComponent<TMP_Text>();
			Ut = currentUI.transform.Find("Outputs/U output").GetComponent<TMP_Text>();
			Umaxt = currentUI.transform.Find("Outputs/Umax output").GetComponent<TMP_Text>();
			Urt = currentUI.transform.Find("Outputs/Ur output").GetComponent<TMP_Text>();
			Rt = currentUI.transform.Find("Outputs/R output").GetComponent<TMP_Text>();
			omegat = currentUI.transform.Find("Outputs/Omega output").GetComponent<TMP_Text>();
			mut = currentUI.transform.Find("Outputs/Mu output").GetComponent<TMP_Text>();
			Tt = currentUI.transform.Find("Outputs/T output").GetComponent<TMP_Text>();
			Pt = currentUI.transform.Find("Outputs/P output").GetComponent<TMP_Text>();
		}
		else if(selectionDropdown.value==1) {
			rlcSeries.typeOfCircuit = "C";
			CGraphics.SetActive(true);
			R_UI.SetActive(false);
			C_UI.SetActive(true);
			L_UI.SetActive(false);
			RL_UI.SetActive(false);
			RC_UI.SetActive(false);
			RLC_UI.SetActive(false);
			currentUI = C_UI;
			inputs = currentUI.transform.GetChild(0).gameObject;
			outputs = currentUI.transform.GetChild(1).gameObject;
			I = currentUI.transform.Find("Inputs/Intensity input field").GetComponent<TMP_InputField>();
			Imax = currentUI.transform.Find("Inputs/Maximum intensity input field").GetComponent<TMP_InputField>();
			U = currentUI.transform.Find("Inputs/Voltage input field").GetComponent<TMP_InputField>();
			Umax = currentUI.transform.Find("Inputs/Maximum voltage input field").GetComponent<TMP_InputField>();
			UC = currentUI.transform.Find("Inputs/UC input field").GetComponent<TMP_InputField>();
			Z = currentUI.transform.Find("Inputs/Impedance input field").GetComponent<TMP_InputField>();
			XC = currentUI.transform.Find("Inputs/Capacitive reactance input field").GetComponent<TMP_InputField>();
			omega = currentUI.transform.Find("Inputs/Pulsation input field").GetComponent<TMP_InputField>();
			mu = currentUI.transform.Find("Inputs/Frequency input field").GetComponent<TMP_InputField>();
			T = currentUI.transform.Find("Inputs/Period input field").GetComponent<TMP_InputField>();
			C = currentUI.transform.Find("Inputs/Capacitance input field").GetComponent<TMP_InputField>();
			Pr = currentUI.transform.Find("Inputs/Reactive power input field").GetComponent<TMP_InputField>();

			Id = currentUI.transform.Find("Inputs/Intensity dropdown").GetComponent<TMP_Dropdown>();
			Imaxd = currentUI.transform.Find("Inputs/Maximum intensity dropdown").GetComponent<TMP_Dropdown>();
			Ud = currentUI.transform.Find("Inputs/Voltage dropdown").GetComponent<TMP_Dropdown>();
			Umaxd = currentUI.transform.Find("Inputs/Maximum voltage dropdown").GetComponent<TMP_Dropdown>();
			UCd = currentUI.transform.Find("Inputs/UC dropdown").GetComponent<TMP_Dropdown>();
			Zd = currentUI.transform.Find("Inputs/Impedance dropdown").GetComponent<TMP_Dropdown>();
			XCd = currentUI.transform.Find("Inputs/Capacitive reactance dropdown").GetComponent<TMP_Dropdown>();
			omegad = currentUI.transform.Find("Inputs/Pulsation dropdown").GetComponent<TMP_Dropdown>();
			mud = currentUI.transform.Find("Inputs/Frequency dropdown").GetComponent<TMP_Dropdown>();
			Td = currentUI.transform.Find("Inputs/Period dropdown").GetComponent<TMP_Dropdown>();
			Cd = currentUI.transform.Find("Inputs/Capacitance dropdown").GetComponent<TMP_Dropdown>();
			Prd = currentUI.transform.Find("Inputs/Reactive power dropdown").GetComponent<TMP_Dropdown>();

			It = currentUI.transform.Find("Outputs/I output").GetComponent<TMP_Text>();
			Imaxt = currentUI.transform.Find("Outputs/Imax output").GetComponent<TMP_Text>();
			Ut = currentUI.transform.Find("Outputs/U output").GetComponent<TMP_Text>();
			Umaxt = currentUI.transform.Find("Outputs/Umax output").GetComponent<TMP_Text>();
			UCt = currentUI.transform.Find("Outputs/UC output").GetComponent<TMP_Text>();
			Zt = currentUI.transform.Find("Outputs/Z output").GetComponent<TMP_Text>();
			XCt = currentUI.transform.Find("Outputs/XC output").GetComponent<TMP_Text>();
			omegat = currentUI.transform.Find("Outputs/Omega output").GetComponent<TMP_Text>();
			mut = currentUI.transform.Find("Outputs/Mu output").GetComponent<TMP_Text>();
			Tt = currentUI.transform.Find("Outputs/T output").GetComponent<TMP_Text>();
			Ct = currentUI.transform.Find("Outputs/C output").GetComponent<TMP_Text>();
			Prt = currentUI.transform.Find("Outputs/Pr output").GetComponent<TMP_Text>();
		}
		else if(selectionDropdown.value==2) {
			rlcSeries.typeOfCircuit = "L";
			LGraphics.SetActive(true);
			R_UI.SetActive(false);
			C_UI.SetActive(false);
			L_UI.SetActive(true);
			RL_UI.SetActive(false);
			RC_UI.SetActive(false);
			RLC_UI.SetActive(false);
			currentUI = L_UI;
			inputs = currentUI.transform.GetChild(0).gameObject;
			outputs = currentUI.transform.GetChild(1).gameObject;
			I = currentUI.transform.Find("Inputs/Intensity input field").GetComponent<TMP_InputField>();
			Imax = currentUI.transform.Find("Inputs/Maximum intensity input field").GetComponent<TMP_InputField>();
			U = currentUI.transform.Find("Inputs/Voltage input field").GetComponent<TMP_InputField>();
			Umax = currentUI.transform.Find("Inputs/Maximum voltage input field").GetComponent<TMP_InputField>();
			UL = currentUI.transform.Find("Inputs/UL input field").GetComponent<TMP_InputField>();
			Z = currentUI.transform.Find("Inputs/Impedance input field").GetComponent<TMP_InputField>();
			XL = currentUI.transform.Find("Inputs/Inductive reactance input field").GetComponent<TMP_InputField>();
			omega = currentUI.transform.Find("Inputs/Pulsation input field").GetComponent<TMP_InputField>();
			mu = currentUI.transform.Find("Inputs/Frequency input field").GetComponent<TMP_InputField>();
			T = currentUI.transform.Find("Inputs/Period input field").GetComponent<TMP_InputField>();
			L = currentUI.transform.Find("Inputs/Inductance input field").GetComponent<TMP_InputField>();
			Pr = currentUI.transform.Find("Inputs/Reactive power input field").GetComponent<TMP_InputField>();

			Id = currentUI.transform.Find("Inputs/Intensity dropdown").GetComponent<TMP_Dropdown>();
			Imaxd = currentUI.transform.Find("Inputs/Maximum intensity dropdown").GetComponent<TMP_Dropdown>();
			Ud = currentUI.transform.Find("Inputs/Voltage dropdown").GetComponent<TMP_Dropdown>();
			Umaxd = currentUI.transform.Find("Inputs/Maximum voltage dropdown").GetComponent<TMP_Dropdown>();
			ULd = currentUI.transform.Find("Inputs/UL dropdown").GetComponent<TMP_Dropdown>();
			Zd = currentUI.transform.Find("Inputs/Impedance dropdown").GetComponent<TMP_Dropdown>();
			XLd = currentUI.transform.Find("Inputs/Inductive reactance dropdown").GetComponent<TMP_Dropdown>();
			omegad = currentUI.transform.Find("Inputs/Pulsation dropdown").GetComponent<TMP_Dropdown>();
			mud = currentUI.transform.Find("Inputs/Frequency dropdown").GetComponent<TMP_Dropdown>();
			Td = currentUI.transform.Find("Inputs/Period dropdown").GetComponent<TMP_Dropdown>();
			Ld = currentUI.transform.Find("Inputs/Inductance dropdown").GetComponent<TMP_Dropdown>();
			Prd = currentUI.transform.Find("Inputs/Reactive power dropdown").GetComponent<TMP_Dropdown>();

			It = currentUI.transform.Find("Outputs/I output").GetComponent<TMP_Text>();
			Imaxt = currentUI.transform.Find("Outputs/Imax output").GetComponent<TMP_Text>();
			Ut = currentUI.transform.Find("Outputs/U output").GetComponent<TMP_Text>();
			Umaxt = currentUI.transform.Find("Outputs/Umax output").GetComponent<TMP_Text>();
			ULt = currentUI.transform.Find("Outputs/UL output").GetComponent<TMP_Text>();
			Zt = currentUI.transform.Find("Outputs/Z output").GetComponent<TMP_Text>();
			XLt = currentUI.transform.Find("Outputs/XL output").GetComponent<TMP_Text>();
			omegat = currentUI.transform.Find("Outputs/Omega output").GetComponent<TMP_Text>();
			mut = currentUI.transform.Find("Outputs/Mu output").GetComponent<TMP_Text>();
			Tt = currentUI.transform.Find("Outputs/T output").GetComponent<TMP_Text>();
			Lt = currentUI.transform.Find("Outputs/L output").GetComponent<TMP_Text>();
			Prt = currentUI.transform.Find("Outputs/Pr output").GetComponent<TMP_Text>();
		}
		else if(selectionDropdown.value==3) {
			rlcSeries.typeOfCircuit = "RL";
			RLGraphics.SetActive(true);
			R_UI.SetActive(false);
			C_UI.SetActive(false);
			L_UI.SetActive(false);
			RL_UI.SetActive(true);
			RC_UI.SetActive(false);
			RLC_UI.SetActive(false);
			currentUI = RL_UI;
			inputs = currentUI.transform.GetChild(0).gameObject;
			outputs = currentUI.transform.GetChild(1).gameObject;
			I = currentUI.transform.Find("Inputs/Intensity input field").GetComponent<TMP_InputField>();
			Imax = currentUI.transform.Find("Inputs/Maximum intensity input field").GetComponent<TMP_InputField>();
			U = currentUI.transform.Find("Inputs/Voltage input field").GetComponent<TMP_InputField>();
			Umax = currentUI.transform.Find("Inputs/Maximum voltage input field").GetComponent<TMP_InputField>();
			Ur = currentUI.transform.Find("Inputs/Resistor voltage input field").GetComponent<TMP_InputField>();
			Ucoil = currentUI.transform.Find("Inputs/Coil voltage input field").GetComponent<TMP_InputField>();
			UL = currentUI.transform.Find("Inputs/UL input field").GetComponent<TMP_InputField>();
			Z = currentUI.transform.Find("Inputs/Impedance input field").GetComponent<TMP_InputField>();
			XL = currentUI.transform.Find("Inputs/Inductive reactance input field").GetComponent<TMP_InputField>();
			R = currentUI.transform.Find("Inputs/Resistance input field").GetComponent<TMP_InputField>();
			omega = currentUI.transform.Find("Inputs/Pulsation input field").GetComponent<TMP_InputField>();
			mu = currentUI.transform.Find("Inputs/Frequency input field").GetComponent<TMP_InputField>();
			T = currentUI.transform.Find("Inputs/Period input field").GetComponent<TMP_InputField>();
			phi = currentUI.transform.Find("Inputs/Phase shift input field").GetComponent<TMP_InputField>();
			cosPhi = currentUI.transform.Find("Inputs/Power factor input field").GetComponent<TMP_InputField>();
			L = currentUI.transform.Find("Inputs/Inductance input field").GetComponent<TMP_InputField>();
			P = currentUI.transform.Find("Inputs/Active power input field").GetComponent<TMP_InputField>();
			Pr = currentUI.transform.Find("Inputs/Reactive power input field").GetComponent<TMP_InputField>();
			Pa = currentUI.transform.Find("Inputs/Apparent power input field").GetComponent<TMP_InputField>();

			Id = currentUI.transform.Find("Inputs/Intensity dropdown").GetComponent<TMP_Dropdown>();
			Imaxd = currentUI.transform.Find("Inputs/Maximum intensity dropdown").GetComponent<TMP_Dropdown>();
			Ud = currentUI.transform.Find("Inputs/Voltage dropdown").GetComponent<TMP_Dropdown>();
			Umaxd = currentUI.transform.Find("Inputs/Maximum voltage dropdown").GetComponent<TMP_Dropdown>();
			Urd = currentUI.transform.Find("Inputs/Resistor voltage dropdown").GetComponent<TMP_Dropdown>();
			Ucoild = currentUI.transform.Find("Inputs/Coil voltage dropdown").GetComponent<TMP_Dropdown>();
			ULd = currentUI.transform.Find("Inputs/UL dropdown").GetComponent<TMP_Dropdown>();
			Zd = currentUI.transform.Find("Inputs/Impedance dropdown").GetComponent<TMP_Dropdown>();
			XLd = currentUI.transform.Find("Inputs/Inductive reactance dropdown").GetComponent<TMP_Dropdown>();
			Rd = currentUI.transform.Find("Inputs/Resistance dropdown").GetComponent<TMP_Dropdown>();
			omegad = currentUI.transform.Find("Inputs/Pulsation dropdown").GetComponent<TMP_Dropdown>();
			mud = currentUI.transform.Find("Inputs/Frequency dropdown").GetComponent<TMP_Dropdown>();
			Td = currentUI.transform.Find("Inputs/Period dropdown").GetComponent<TMP_Dropdown>();
			phid = currentUI.transform.Find("Inputs/Phase shift dropdown").GetComponent<TMP_Dropdown>();
			Ld = currentUI.transform.Find("Inputs/Inductance dropdown").GetComponent<TMP_Dropdown>();
			Pd = currentUI.transform.Find("Inputs/Active power dropdown").GetComponent<TMP_Dropdown>();
			Prd = currentUI.transform.Find("Inputs/Reactive power dropdown").GetComponent<TMP_Dropdown>();
			Pad = currentUI.transform.Find("Inputs/Apparent power dropdown").GetComponent<TMP_Dropdown>();

			It = currentUI.transform.Find("Outputs/I output").GetComponent<TMP_Text>();
			Imaxt = currentUI.transform.Find("Outputs/Imax output").GetComponent<TMP_Text>();
			Ut = currentUI.transform.Find("Outputs/U output").GetComponent<TMP_Text>();
			Umaxt = currentUI.transform.Find("Outputs/Umax output").GetComponent<TMP_Text>();
			Urt = currentUI.transform.Find("Outputs/Ur output").GetComponent<TMP_Text>();
			Ucoilt = currentUI.transform.Find("Outputs/Ucoil output").GetComponent<TMP_Text>();
			ULt = currentUI.transform.Find("Outputs/UL output").GetComponent<TMP_Text>();
			Zt = currentUI.transform.Find("Outputs/Z output").GetComponent<TMP_Text>();
			XLt = currentUI.transform.Find("Outputs/XL output").GetComponent<TMP_Text>();
			Rt = currentUI.transform.Find("Outputs/R output").GetComponent<TMP_Text>();
			omegat = currentUI.transform.Find("Outputs/Omega output").GetComponent<TMP_Text>();
			mut = currentUI.transform.Find("Outputs/Mu output").GetComponent<TMP_Text>();
			Tt = currentUI.transform.Find("Outputs/T output").GetComponent<TMP_Text>();
			phit = currentUI.transform.Find("Outputs/Phi output").GetComponent<TMP_Text>();
			cosPhit = currentUI.transform.Find("Outputs/cosPhi output").GetComponent<TMP_Text>();
			Lt = currentUI.transform.Find("Outputs/L output").GetComponent<TMP_Text>();
			Pt = currentUI.transform.Find("Outputs/P output").GetComponent<TMP_Text>();
			Prt = currentUI.transform.Find("Outputs/Pr output").GetComponent<TMP_Text>();
			Pat = currentUI.transform.Find("Outputs/Pa output").GetComponent<TMP_Text>();
		}
		else if(selectionDropdown.value==4) {
			rlcSeries.typeOfCircuit = "RC";
			RCGraphics.SetActive(true);
			R_UI.SetActive(false);
			C_UI.SetActive(false);
			L_UI.SetActive(false);
			RL_UI.SetActive(false);
			RC_UI.SetActive(true);
			RLC_UI.SetActive(false);
			currentUI = RC_UI;
			inputs = currentUI.transform.GetChild(0).gameObject;
			outputs = currentUI.transform.GetChild(1).gameObject;
			I = currentUI.transform.Find("Inputs/Intensity input field").GetComponent<TMP_InputField>();
			Imax = currentUI.transform.Find("Inputs/Maximum intensity input field").GetComponent<TMP_InputField>();
			U = currentUI.transform.Find("Inputs/Voltage input field").GetComponent<TMP_InputField>();
			Umax = currentUI.transform.Find("Inputs/Maximum voltage input field").GetComponent<TMP_InputField>();
			Ur = currentUI.transform.Find("Inputs/Resistor voltage input field").GetComponent<TMP_InputField>();
			Ucap = currentUI.transform.Find("Inputs/Capacitor voltage input field").GetComponent<TMP_InputField>();
			UC = currentUI.transform.Find("Inputs/UC input field").GetComponent<TMP_InputField>();
			Z = currentUI.transform.Find("Inputs/Impedance input field").GetComponent<TMP_InputField>();
			XC = currentUI.transform.Find("Inputs/Capacitive reactance input field").GetComponent<TMP_InputField>();
			R = currentUI.transform.Find("Inputs/Resistance input field").GetComponent<TMP_InputField>();
			omega = currentUI.transform.Find("Inputs/Pulsation input field").GetComponent<TMP_InputField>();
			mu = currentUI.transform.Find("Inputs/Frequency input field").GetComponent<TMP_InputField>();
			T = currentUI.transform.Find("Inputs/Period input field").GetComponent<TMP_InputField>();
			phi = currentUI.transform.Find("Inputs/Phase shift input field").GetComponent<TMP_InputField>();
			cosPhi = currentUI.transform.Find("Inputs/Power factor input field").GetComponent<TMP_InputField>();
			C = currentUI.transform.Find("Inputs/Capacitance input field").GetComponent<TMP_InputField>();
			P = currentUI.transform.Find("Inputs/Active power input field").GetComponent<TMP_InputField>();
			Pr = currentUI.transform.Find("Inputs/Reactive power input field").GetComponent<TMP_InputField>();
			Pa = currentUI.transform.Find("Inputs/Apparent power input field").GetComponent<TMP_InputField>();

			Id = currentUI.transform.Find("Inputs/Intensity dropdown").GetComponent<TMP_Dropdown>();
			Imaxd = currentUI.transform.Find("Inputs/Maximum intensity dropdown").GetComponent<TMP_Dropdown>();
			Ud = currentUI.transform.Find("Inputs/Voltage dropdown").GetComponent<TMP_Dropdown>();
			Umaxd = currentUI.transform.Find("Inputs/Maximum voltage dropdown").GetComponent<TMP_Dropdown>();
			Urd = currentUI.transform.Find("Inputs/Resistor voltage dropdown").GetComponent<TMP_Dropdown>();
			Ucapd = currentUI.transform.Find("Inputs/Capacitor voltage dropdown").GetComponent<TMP_Dropdown>();
			UCd = currentUI.transform.Find("Inputs/UC dropdown").GetComponent<TMP_Dropdown>();
			Zd = currentUI.transform.Find("Inputs/Impedance dropdown").GetComponent<TMP_Dropdown>();
			XCd = currentUI.transform.Find("Inputs/Capacitive reactance dropdown").GetComponent<TMP_Dropdown>();
			Rd = currentUI.transform.Find("Inputs/Resistance dropdown").GetComponent<TMP_Dropdown>();
			omegad = currentUI.transform.Find("Inputs/Pulsation dropdown").GetComponent<TMP_Dropdown>();
			mud = currentUI.transform.Find("Inputs/Frequency dropdown").GetComponent<TMP_Dropdown>();
			Td = currentUI.transform.Find("Inputs/Period dropdown").GetComponent<TMP_Dropdown>();
			phid = currentUI.transform.Find("Inputs/Phase shift dropdown").GetComponent<TMP_Dropdown>();
			Cd = currentUI.transform.Find("Inputs/Capacitance dropdown").GetComponent<TMP_Dropdown>();
			Pd = currentUI.transform.Find("Inputs/Active power dropdown").GetComponent<TMP_Dropdown>();
			Prd = currentUI.transform.Find("Inputs/Reactive power dropdown").GetComponent<TMP_Dropdown>();
			Pad = currentUI.transform.Find("Inputs/Apparent power dropdown").GetComponent<TMP_Dropdown>();

			It = currentUI.transform.Find("Outputs/I output").GetComponent<TMP_Text>();
			Imaxt = currentUI.transform.Find("Outputs/Imax output").GetComponent<TMP_Text>();
			Ut = currentUI.transform.Find("Outputs/U output").GetComponent<TMP_Text>();
			Umaxt = currentUI.transform.Find("Outputs/Umax output").GetComponent<TMP_Text>();
			Urt = currentUI.transform.Find("Outputs/Ur output").GetComponent<TMP_Text>();
			Ucapt = currentUI.transform.Find("Outputs/Ucap output").GetComponent<TMP_Text>();
			UCt = currentUI.transform.Find("Outputs/UC output").GetComponent<TMP_Text>();
			Zt = currentUI.transform.Find("Outputs/Z output").GetComponent<TMP_Text>();
			XCt = currentUI.transform.Find("Outputs/XC output").GetComponent<TMP_Text>();
			Rt = currentUI.transform.Find("Outputs/R output").GetComponent<TMP_Text>();
			omegat = currentUI.transform.Find("Outputs/Omega output").GetComponent<TMP_Text>();
			mut = currentUI.transform.Find("Outputs/Mu output").GetComponent<TMP_Text>();
			Tt = currentUI.transform.Find("Outputs/T output").GetComponent<TMP_Text>();
			phit = currentUI.transform.Find("Outputs/Phi output").GetComponent<TMP_Text>();
			cosPhit = currentUI.transform.Find("Outputs/cosPhi output").GetComponent<TMP_Text>();
			Ct = currentUI.transform.Find("Outputs/C output").GetComponent<TMP_Text>();
			Pt = currentUI.transform.Find("Outputs/P output").GetComponent<TMP_Text>();
			Prt = currentUI.transform.Find("Outputs/Pr output").GetComponent<TMP_Text>();
			Pat = currentUI.transform.Find("Outputs/Pa output").GetComponent<TMP_Text>();
		}
		else if(selectionDropdown.value==5) {
			rlcSeries.typeOfCircuit = "RLC";
			RLCGraphics.SetActive(true);
			R_UI.SetActive(false);
			C_UI.SetActive(false);
			L_UI.SetActive(false);
			RL_UI.SetActive(false);
			RC_UI.SetActive(false);
			RLC_UI.SetActive(true);
			currentUI = RLC_UI;
			inputs = currentUI.transform.GetChild(0).gameObject;
			outputs = currentUI.transform.GetChild(1).gameObject;
			I = currentUI.transform.Find("Inputs/Intensity input field").GetComponent<TMP_InputField>();
			Imax = currentUI.transform.Find("Inputs/Maximum intensity input field").GetComponent<TMP_InputField>();
			U = currentUI.transform.Find("Inputs/Voltage input field").GetComponent<TMP_InputField>();
			Umax = currentUI.transform.Find("Inputs/Maximum voltage input field").GetComponent<TMP_InputField>();
			Ur = currentUI.transform.Find("Inputs/Resistor voltage input field").GetComponent<TMP_InputField>();
			Ucoil = currentUI.transform.Find("Inputs/Coil voltage input field").GetComponent<TMP_InputField>();
			Ucap = currentUI.transform.Find("Inputs/Capacitor voltage input field").GetComponent<TMP_InputField>();
			UC = currentUI.transform.Find("Inputs/UC input field").GetComponent<TMP_InputField>();
			UL = currentUI.transform.Find("Inputs/UL input field").GetComponent<TMP_InputField>();
			Z = currentUI.transform.Find("Inputs/Impedance input field").GetComponent<TMP_InputField>();
			XC = currentUI.transform.Find("Inputs/Capacitive reactance input field").GetComponent<TMP_InputField>();
			XL = currentUI.transform.Find("Inputs/Inductive reactance input field").GetComponent<TMP_InputField>();
			R = currentUI.transform.Find("Inputs/Resistance input field").GetComponent<TMP_InputField>();
			omega = currentUI.transform.Find("Inputs/Pulsation input field").GetComponent<TMP_InputField>();
			mu = currentUI.transform.Find("Inputs/Frequency input field").GetComponent<TMP_InputField>();
			T = currentUI.transform.Find("Inputs/Period input field").GetComponent<TMP_InputField>();
			phi = currentUI.transform.Find("Inputs/Phase shift input field").GetComponent<TMP_InputField>();
			cosPhi = currentUI.transform.Find("Inputs/Power factor input field").GetComponent<TMP_InputField>();
			L = currentUI.transform.Find("Inputs/Inductance input field").GetComponent<TMP_InputField>();
			C = currentUI.transform.Find("Inputs/Capacitance input field").GetComponent<TMP_InputField>();
			P = currentUI.transform.Find("Inputs/Active power input field").GetComponent<TMP_InputField>();
			Pr = currentUI.transform.Find("Inputs/Reactive power input field").GetComponent<TMP_InputField>();
			Pa = currentUI.transform.Find("Inputs/Apparent power input field").GetComponent<TMP_InputField>();
			muRez = currentUI.transform.Find("Inputs/Resonance frequency input field").GetComponent<TMP_InputField>();
			resonanceOmega = currentUI.transform.Find("Inputs/Resonance pulsation input field").GetComponent<TMP_InputField>();
			Irez = currentUI.transform.Find("Inputs/Resonance intensity input field").GetComponent<TMP_InputField>();
			Q = currentUI.transform.Find("Inputs/Quality factor input field").GetComponent<TMP_InputField>();

			Id = currentUI.transform.Find("Inputs/Intensity dropdown").GetComponent<TMP_Dropdown>();
			Imaxd = currentUI.transform.Find("Inputs/Maximum intensity dropdown").GetComponent<TMP_Dropdown>();
			Ud = currentUI.transform.Find("Inputs/Voltage dropdown").GetComponent<TMP_Dropdown>();
			Umaxd = currentUI.transform.Find("Inputs/Maximum voltage dropdown").GetComponent<TMP_Dropdown>();
			Urd = currentUI.transform.Find("Inputs/Resistor voltage dropdown").GetComponent<TMP_Dropdown>();
			Ucoild = currentUI.transform.Find("Inputs/Coil voltage dropdown").GetComponent<TMP_Dropdown>();
			Ucapd = currentUI.transform.Find("Inputs/Capacitor voltage dropdown").GetComponent<TMP_Dropdown>();
			UCd = currentUI.transform.Find("Inputs/UC dropdown").GetComponent<TMP_Dropdown>();
			ULd = currentUI.transform.Find("Inputs/UL dropdown").GetComponent<TMP_Dropdown>();
			Zd = currentUI.transform.Find("Inputs/Impedance dropdown").GetComponent<TMP_Dropdown>();
			XCd = currentUI.transform.Find("Inputs/Capacitive reactance dropdown").GetComponent<TMP_Dropdown>();
			XLd = currentUI.transform.Find("Inputs/Inductive reactance dropdown").GetComponent<TMP_Dropdown>();
			Rd = currentUI.transform.Find("Inputs/Resistance dropdown").GetComponent<TMP_Dropdown>();
			omegad = currentUI.transform.Find("Inputs/Pulsation dropdown").GetComponent<TMP_Dropdown>();
			mud = currentUI.transform.Find("Inputs/Frequency dropdown").GetComponent<TMP_Dropdown>();
			Td = currentUI.transform.Find("Inputs/Period dropdown").GetComponent<TMP_Dropdown>();
			phid = currentUI.transform.Find("Inputs/Phase shift dropdown").GetComponent<TMP_Dropdown>();
			Ld = currentUI.transform.Find("Inputs/Inductance dropdown").GetComponent<TMP_Dropdown>();
			Cd = currentUI.transform.Find("Inputs/Capacitance dropdown").GetComponent<TMP_Dropdown>();
			Pd = currentUI.transform.Find("Inputs/Active power dropdown").GetComponent<TMP_Dropdown>();
			Prd = currentUI.transform.Find("Inputs/Reactive power dropdown").GetComponent<TMP_Dropdown>();
			Pad = currentUI.transform.Find("Inputs/Apparent power dropdown").GetComponent<TMP_Dropdown>();
			muRezd = currentUI.transform.Find("Inputs/Resonance frequency dropdown").GetComponent<TMP_Dropdown>();
			resonanceOmegad = currentUI.transform.Find("Inputs/Resonance pulsation dropdown").GetComponent<TMP_Dropdown>();
			Irezd = currentUI.transform.Find("Inputs/Resonance intensity dropdown").GetComponent<TMP_Dropdown>();

			It = currentUI.transform.Find("Outputs/I output").GetComponent<TMP_Text>();
			Imaxt = currentUI.transform.Find("Outputs/Imax output").GetComponent<TMP_Text>();
			Ut = currentUI.transform.Find("Outputs/U output").GetComponent<TMP_Text>();
			Umaxt = currentUI.transform.Find("Outputs/Umax output").GetComponent<TMP_Text>();
			Urt = currentUI.transform.Find("Outputs/Ur output").GetComponent<TMP_Text>();
			Ucoilt = currentUI.transform.Find("Outputs/Ucoil output").GetComponent<TMP_Text>();
			Ucapt = currentUI.transform.Find("Outputs/Ucap output").GetComponent<TMP_Text>();
			UCt = currentUI.transform.Find("Outputs/UC output").GetComponent<TMP_Text>();
			ULt = currentUI.transform.Find("Outputs/UL output").GetComponent<TMP_Text>();
			Zt = currentUI.transform.Find("Outputs/Z output").GetComponent<TMP_Text>();
			XCt = currentUI.transform.Find("Outputs/XC output").GetComponent<TMP_Text>();
			XLt = currentUI.transform.Find("Outputs/XL output").GetComponent<TMP_Text>();
			Rt = currentUI.transform.Find("Outputs/R output").GetComponent<TMP_Text>();
			omegat = currentUI.transform.Find("Outputs/Omega output").GetComponent<TMP_Text>();
			mut = currentUI.transform.Find("Outputs/Mu output").GetComponent<TMP_Text>();
			Tt = currentUI.transform.Find("Outputs/T output").GetComponent<TMP_Text>();
			phit = currentUI.transform.Find("Outputs/Phi output").GetComponent<TMP_Text>();
			cosPhit = currentUI.transform.Find("Outputs/cosPhi output").GetComponent<TMP_Text>();
			Lt = currentUI.transform.Find("Outputs/L output").GetComponent<TMP_Text>();
			Ct = currentUI.transform.Find("Outputs/C output").GetComponent<TMP_Text>();
			Pt = currentUI.transform.Find("Outputs/P output").GetComponent<TMP_Text>();
			Prt = currentUI.transform.Find("Outputs/Pr output").GetComponent<TMP_Text>();
			Pat = currentUI.transform.Find("Outputs/Pa output").GetComponent<TMP_Text>();
			muRezt = currentUI.transform.Find("Outputs/Mu rez output").GetComponent<TMP_Text>();
			resonanceOmegat = currentUI.transform.Find("Outputs/Omega rez output").GetComponent<TMP_Text>();
			Irezt = currentUI.transform.Find("Outputs/Irez output").GetComponent<TMP_Text>();
			Qt = currentUI.transform.Find("Outputs/Q output").GetComponent<TMP_Text>();
		}
		ShowHideDataUI();
	}
	[ContextMenu("Show or hide data UI.")]
	public void ShowHideDataUI() {
		currentUI.SetActive(!currentUI.activeSelf);
	}
	void HideAllCircuitGraphics() {
		RLCGraphics.SetActive(false);
		RGraphics.SetActive(false);
		LGraphics.SetActive(false);
		CGraphics.SetActive(false);
		RLGraphics.SetActive(false);
		RCGraphics.SetActive(false);
	}
	string ScientificNotation(double number, string unitOfMeasurement) {
		//Weird method that works.
		string formattedString = "", powerPrefix = "";
		double formattedNumber = 0;
		if(number<=System.Math.Pow(10, 12)&&number>=System.Math.Pow(10, 9))	{
			powerPrefix = "G";
			formattedNumber = number/System.Math.Pow(10, 9);
		}
		else if(number<=System.Math.Pow(10, 9)&&number>=System.Math.Pow(10, 6)) {
			powerPrefix = "M";
			formattedNumber = number/System.Math.Pow(10, 6);
		}
		else if(number<=System.Math.Pow(10, 6)&&number>=System.Math.Pow(10, 3)) {
			powerPrefix = "k";
			formattedNumber = number/System.Math.Pow(10, 3);
		}
		else if(number<=System.Math.Pow(10, 3)&&number>=System.Math.Pow(10, 0)) {
			powerPrefix = "";
			formattedNumber = number; //Extremely useful code!
		}
		else if(number<=System.Math.Pow(10, 0)&&number>=System.Math.Pow(10, -3)) {
			powerPrefix = "m";
			formattedNumber = number/System.Math.Pow(10, -3);
		}
		else if(number<=System.Math.Pow(10, -3)&&number>=System.Math.Pow(10, -6)) {
			powerPrefix = "μ";
			formattedNumber = number/System.Math.Pow(10, -6);
		}
		else if(number<=System.Math.Pow(10, -6)&&number>=System.Math.Pow(10, -9)) {
			powerPrefix = "n";
			formattedNumber = number/System.Math.Pow(10, -9);
		}
		else if(number<=System.Math.Pow(10, -9)&&number>=System.Math.Pow(10, -12)) {
			powerPrefix = "p";
			formattedNumber = number/System.Math.Pow(10, -12);
		}
		formattedString = formattedNumber.ToString(".0000") + " " + powerPrefix + unitOfMeasurement;
		return formattedString;
	}
}
