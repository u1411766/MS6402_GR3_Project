using UnityEngine;
using System.Collections;

public class HL_touch_interaction_test : MonoBehaviour {




    public Color defoult;
    public Color selectedColor;
    private Material met;
    public Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        met = rend.material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTouchDown()
    {
        met.color = selectedColor;
    }
    void OnTouchUp()
    {
        met.color = defoult;
    }
    void OnTouchStay()
    {
        met.color = selectedColor;
    }
    void OnTouchExit()
    {
        met.color = defoult;
    }
}
