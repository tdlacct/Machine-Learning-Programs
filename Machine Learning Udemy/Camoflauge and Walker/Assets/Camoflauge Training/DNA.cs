using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour {
    //Gene for color
    public float r;
    public float g;
    public float b;
    bool dead = false;
    public float timeToDie;
    public float genescale;
    SpriteRenderer sRenderer;
    Collider2D sCollider;
    // Use this for initialization

    public void OnMouseDown() {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead At: " + timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }
    void Start () {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, b, g);
        transform.localScale *= genescale;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
