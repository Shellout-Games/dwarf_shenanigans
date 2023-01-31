using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private TestRelay testRelay;
    [SerializeField] private Button hostBtn;
    [SerializeField] private Button joinBtn;
    [SerializeField] private TMP_InputField joinCodeFld;
    [SerializeField] private TMP_Text joinCodeUi;

    private void Awake()
    {
        hostBtn.onClick.AddListener(() => {
            testRelay.CreateRelay();

        });

        joinBtn.onClick.AddListener(() => { 
                testRelay.JoinRelay(joinCodeFld.text);
            ;
        });

        
    }
}
