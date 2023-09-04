using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimState : AimBaseState
{
    public override void EnterState(AimStateManager aim)
    {
        aim.animator.SetBool("Aiming", true);
        aim.currentFOV = aim.adsFOV;
    }

    public override void UpdateState(AimStateManager aim)
    {
        if(Input.GetKeyUp(KeyCode.Mouse1)) aim.SwitchState(aim.Hip);
    }
}