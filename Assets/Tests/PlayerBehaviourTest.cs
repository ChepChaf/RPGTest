using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerBehaviourTest
    {
        GameObject player;
        GameObject enemy;

        PlayerBehaviour pc;
        EnemyBehaviour ec;

        [SetUp]
        public void Setup()
        {
            player = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Player"));
            pc = player.GetComponent<PlayerBehaviour>();
           
            enemy = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Enemy"));
            ec = enemy.GetComponent<EnemyBehaviour>();

            pc.enemy = ec;

            pc.InitStats();
            ec.InitStats();

            pc.initActions();
        }

        // A Test behaves as an ordinary method
        [Test]
        public void TakeDamageTest()
        {
            int initialHealth = pc.Health;

            pc.TakeDamage(20);

            Assert.AreEqual(initialHealth - 20, pc.Health);
        }

        [Test]
        public void onClickAttackBtnTest()
        {
            int initialHealth = ec.Health;

            pc.onAttackBtnClick();

            Assert.AreEqual(initialHealth - pc.Attack, ec.Health);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator PlayerBehaviourTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
