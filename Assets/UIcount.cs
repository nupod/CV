using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcount : MonoBehaviour
{

	public Text myText;


    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.T))
		{
			string[] biomes = new string[] { "grasslands", "rainforest", "desert", "rocky", "swamp", "tundra" };
			System.Random random = new System.Random();
			int useBiome = random.Next(biomes.Length);
			string pickBiome = biomes[useBiome];
			myText.text = pickBiome;
		}
    }

	public void Clear()
	{
		myText.text = "tettt";
	}

	public void AddI()
	{
		myText.text = myText.text + "|";
	}
}
