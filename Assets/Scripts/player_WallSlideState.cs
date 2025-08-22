using UnityEngine;

public class player_WallSlideState : EntityState
{
    public player_WallSlideState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }
    
    public override void Update()
    {
        base.Update();
        HandleWallSlide();

        if (player.groundDetected)
        {
            stateMachine.ChangeState(player.idleState);
            player.Flip();
        }
    }

    private void HandleWallSlide()
    {
        if(player.moveInput.y < 0)
        {
            player.SetVelocity(0, rb.linearVelocity.y);
        }
        else
        {
            player.SetVelocity(0, rb.linearVelocity.y * .3f);
        }
    }
}
