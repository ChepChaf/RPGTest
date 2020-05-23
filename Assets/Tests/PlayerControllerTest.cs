using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerControllerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TakeDamagetest()
        {
            GameObject player = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Player"));
            PlayerController pc = player.GetComponent<PlayerController>();

            int initialHealth = pc.stats.health;

            pc.TakeDamage(20);

            Assert.AreEqual(initialHealth - 20, pc.stats.health);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator PlayerControllerTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
