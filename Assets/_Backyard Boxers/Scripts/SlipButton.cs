using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipButton : MonoBehaviour {
    Player player;
    OpponentAI opponent;

    private bool canSlipLeft = true, canSlipRight = true;

    private void Start() {
        player = Player.Instance;
        opponent = OpponentAI.Instance;
    }
    public void OnSlipButtonPressed(bool left) {
        if(left && canSlipLeft) {
            StartCoroutine(SlipLeft());
        } else if(!left && canSlipRight) {
            StartCoroutine(SlipRight());
        }

    }
    private IEnumerator SlipLeft() {
        canSlipLeft = false;
        player.Slip(true);
        yield return new WaitForSeconds(Data.fightSlipDelay);
        canSlipLeft = true;
    }
    private IEnumerator SlipRight() {
        canSlipRight = false;
        player.Slip(false);
        yield return new WaitForSeconds(Data.fightSlipDelay);
        canSlipRight = true;
    }
}