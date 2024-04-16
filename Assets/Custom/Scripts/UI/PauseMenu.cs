using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] private GameObject pauseOverlay;
	private MenuInput menuInput;
	private bool isPaused;

	public void OnPause(InputAction.CallbackContext context) {
		
		if (!isPaused) {
			Time.timeScale = 0;
			isPaused=true;
			pauseOverlay.SetActive(true);
			return;
		}
		else {
			Time.timeScale = 1;
			isPaused=false;
			pauseOverlay.SetActive(false);
		}
		
	}

	private void Awake() {
		menuInput = new MenuInput();
	}

	private void OnEnable() {
		menuInput.Enable();
		menuInput.UI.Pause.performed += OnPause;
	}

	private void OnDisable() {
		menuInput.Disable();
		menuInput.UI.Pause.performed -= OnPause;
	}
}
