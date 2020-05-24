using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EnemyBehaviourTest
    {
        GameObject enemy;
        EnemyBehaviour ec;

        [SetUp]
        public void Setup()
        {
            enemy = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Enemy"));
            ec = enemy.GetComponent<EnemyBehaviour>();

            ec.InitStats();
            ec.initActions();
        }


        [Test]
        public void TakeDamagetest()
        {
            int initialHealth = ec.Health;

            ec.TakeDamage(20);

            Assert.AreEqual(initialHealth - 20, ec.Health);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EnemyBehaviourTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
