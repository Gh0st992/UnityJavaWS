using UnityEngine;
using System.Collections;

public class ClientObject : MonoBehaviour
{

		private ServiceService service;

		private string result_s = "Result";

		private string a_s = "";
		private string b_s = "";

		// Use this for initialization
		void Start ()
		{
				service = new ServiceService ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnGUI ()
		{
				a_s = GUI.TextField (new Rect (10, 10, 150, 25), a_s);
				b_s = GUI.TextField (new Rect (10, 45, 150, 25), b_s);
				if (GUI.Button (new Rect (10, 80, 70, 25), "Add")) {
						result_s = add (double.Parse (a_s), double.Parse (b_s)).ToString ();
				}

				result_s = GUI.TextField (new Rect (90, 80, 70, 25), result_s);

		}

		double add (double a, double b)
		{
				return service.add (a, b);
		}

}
