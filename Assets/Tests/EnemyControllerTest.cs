using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EnemyControllerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TakeDamagetest()
        {
            GameObject enemy = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Enemy"));
            EnemyController ec = enemy.GetComponent<EnemyController>();

            int initialHealth = ec.stats.health;

            ec.TakeDamage(20);

            Assert.AreEqual(initialHealth - 20, ec.stats.health);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EnemyControllerTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
