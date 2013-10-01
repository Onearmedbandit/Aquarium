using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FishSpawn : MonoBehaviour {
	
	public FishPhysics fishBlueprint;
	public FishPhysics fishBlueprint2;
	public int fishCount = 100;
	public int spawnPicker = 0;
	
	public List<FishPhysics> fishList = new List<FishPhysics>();

	// Use this for initialization
	void Start () {
		int currentFishCounter = 0;
		while ( currentFishCounter < fishCount ) {
			
			spawnPicker = Random.Range(0,10);
			
		
			
			if(spawnPicker < 6f)
			{
				
			Vector3 fishPosition = new Vector3 (Random.Range(-10f,10f), Random.Range(-10f,10f), Random.Range(-10f,10f));
			FishPhysics newFish = Instantiate( fishBlueprint, fishPosition,Quaternion.identity) as FishPhysics;
			
			fishList.Add (newFish);
			
			currentFishCounter++;
			}
			else
				
			{
				Vector3 fishPosition = new Vector3 (Random.Range(-10f,10f), Random.Range(-10f,10f), Random.Range(-10f,10f));
			FishPhysics newFish = Instantiate( fishBlueprint2, fishPosition,Quaternion.identity) as FishPhysics;
			
			fishList.Add (newFish);
			
			currentFishCounter++;
			}
				
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ( KeyCode.Space)) {
			foreach (FishPhysics currentFish in fishList) {
				currentFish.destination = Vector3.zero;
			
			}
		}
	
	}
}
