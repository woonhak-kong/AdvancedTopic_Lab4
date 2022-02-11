using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    
    // This test is for verifying that Gem is destroyed when it collides.
    [UnityTest]
    public IEnumerator TestForGemCollision()
    {
        GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/PlayerPaddle");
        GameObject gemPrefab = Resources.Load<GameObject>("Prefabs/Gem");
        GameObject paddle;
        GameObject gem;
        paddle = GameObject.Instantiate(playerPrefab);
        gem = GameObject.Instantiate(gemPrefab);
        
        Assert.IsNotNull(playerPrefab);
        Assert.IsNotNull(gem);
        yield return null;

        // translate gem to the paddle
        gem.transform.position = paddle.transform.position;
        
        // wait for collision process
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();

        // if true, gem was destroyed
        Assert.IsTrue(gem == null);

    }
}
