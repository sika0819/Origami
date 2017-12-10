using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPath : MonoBehaviour {
    public Transform target;
    public Transform myPos;
    LineRenderer linedrawer;
    float distance;
    Vector3[] path;
    private Vector2 size;

    // Use this for initialization
    void Start () {
        linedrawer = GetComponent<LineRenderer>();
        path = new Vector3[2];
        path[0] = myPos.transform.position;
        path[1] = target.transform.position;
        linedrawer.SetPositions(path);
        
	}
	
	// Update is called once per frame
	void Update () {
        path[0] = new Vector3(myPos.transform.position.x, 0, myPos.transform.position.z);
        path[1] = new Vector3(target.transform.position.x, 0, target.transform.position.z);
        linedrawer.SetPositions(path);
        distance =Mathf.Abs(Vector3.Distance(myPos.transform.position, target.transform.position));
        size = new Vector2(Mathf.CeilToInt(distance*10),1);
        linedrawer.material.SetTextureScale("_MainTex", size);
       
    }
}
