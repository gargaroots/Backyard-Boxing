using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour {
    [SerializeField] List<GameObject> listUMAS;
    [SerializeField] Transform UMASpawnPosition;

    private void Start() {
        Data.gameState = Data.GameStates.Loading;
        Data.gameState = Data.GameStates.SelectingCharacter;

        GameObject defaultChar = listUMAS[0];
        InstantiateCharacter(defaultChar);
    }

    public void OnButtonCharacterPressed(int buttonIndex) {
        InstantiateCharacter(listUMAS[buttonIndex]);
    }

    private void InstantiateCharacter(GameObject newChar) {
        // Data.player.DestroyUMA();
        var currentUMA = Instantiate(newChar, UMASpawnPosition, false);
        // Data.player.SetUMA(currentUMA);
    }
}