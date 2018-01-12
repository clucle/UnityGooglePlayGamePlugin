
using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.UI;

public class plugin : MonoBehaviour
{

	public Text UId;
	
	// Use this for initialization
	void Start ()
	{
		PlayGamesPlatform.DebugLogEnabled = true;
		PlayGamesPlatform.Activate();
		LogIn();
	}

	public void LogIn()
	{
		Social.localUser.Authenticate((bool success) =>
		{
			if (success)
			{
				Debug.Log("login success");
				Debug.Log(Social.localUser.id);
				Debug.Log(Social.localUser.userName);
				UId.text = Social.localUser.id;
			}
			else
			{
				Debug.Log("login fail");
			}

		});
	}

	public void LogOut()
	{
		Debug.Log("LogOut");
		((PlayGamesPlatform)Social.Active).SignOut();
	}
}
