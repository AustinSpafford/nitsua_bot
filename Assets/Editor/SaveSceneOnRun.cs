﻿using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public class OnUnityLoad
{
	static OnUnityLoad ()
	{
		EditorApplication.playmodeStateChanged = OnPlaymodeStateChanged;
	}

	private static void OnPlaymodeStateChanged ()
	{
		// If the user _just_ pressed the Play button.
		if (EditorApplication.isPlayingOrWillChangePlaymode &&
			!EditorApplication.isPlaying)
		{
			EditorSceneManager.SaveOpenScenes();

			AssetDatabase.SaveAssets();
		}
	}
}