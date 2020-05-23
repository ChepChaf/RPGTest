using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerControllerTest
    {
        GameObject player;
        GameObject enemy;

        PlayerController pc;
        EnemyController ec;

        [SetUp]
        public void Setup()
        {
            player = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Player"));
            pc = player.GetComponent<PlayerController>();
           
            enemy = MonoBehaviour.Instantiate(
                Resources.Load<GameObject>("Prefabs/Enemy"));
            ec = enemy.GetComponent<EnemyController>();

            pc.enemy = ec;

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
        public IEnumerator PlayerControllerTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
