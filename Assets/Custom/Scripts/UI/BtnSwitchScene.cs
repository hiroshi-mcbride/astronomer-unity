using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BtnSwitchScene : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string SceneName;

    public void OnPointerClick(PointerEventData eventData) {
        Utility.LoadScene(SceneName);
    }
}
