using NUnit.Framework;

namespace Tests
{
    using System;
    using FightingArena;
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(null, 18, 120)]
        [TestCase("Pesho", 0, 120)]
        [TestCase("Pesho", -10, 120)]
        [TestCase("Pesho", 5, -150)]
        [TestCase("", 24, 120)]
        public void ConstructorShouldThrowsArgumentExceptionWhenInvalidParameter(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }
        [Test]
        public void ConstructorShouldWokrCorrectly()
        {
            var warrior = new Warrior("Stefan", 18, 120);
            Assert.AreEqual("Stefan", warrior.Name);
            Assert.AreEqual(18, warrior.Damage);
            Assert.AreEqual(120, warrior.HP);
        }

        [Test]
        [TestCase("Pesho", 50, 100, "Stefan", 18, 49)]
        [TestCase("Pesho", 15, 100, "Stefan", 18, 30)]
        [TestCase("Pesho", 15, 100, "Stefan", 18, 20)]
        [TestCase("Pesho", 15, 30, "Stefan", 20, 55)]
        [TestCase("Pesho", 15, 11, "Stefan", 20, 55)]

        public void WarriorMethodAttackShouldThrowInvalidOperationExceptionIfYouTryToAttackStrongerEnemy
            (string firstWarriorName, int firstWarriorDamage, int firstWarriorHP,
            string secondWarriorName, int secondWarriorDamage, int secondWarriorHp)
        {
            var parameterWarrior = new Warrior(firstWarriorName, firstWarriorDamage, firstWarriorHP);
            var callerWarrior = new Warrior(secondWarriorName, secondWarriorDamage, secondWarriorHp);
            Assert.Throws<InvalidOperationException>(() => callerWarrior.Attack(parameterWarrior));
        }

        [Test]
        public void WarriorAttackMethodShouldWorkCorrectly()
        {
            var stronger = new Warrior("Stefan", 18, 120);
            var weaker = new Warrior("Emil", 18, 120);
            var expectedHp = 102;
            weaker.Attack(stronger);
            Assert.AreEqual(expectedHp, weaker.HP);
        }
        [Test]
        public void WarriorAttackMethodShouldWorkCorrectlyIfDamageIsMoreThanHealth()
        {
            var stronger = new Warrior("Stefan", 60, 100);
            var weaker = new Warrior("Emil", 30, 95);
            stronger.Attack(weaker);
            Assert.AreEqual(70, stronger.HP);
            Assert.AreEqual(35, weaker.HP);
            stronger.Attack(weaker);
            Assert.AreEqual(40, stronger.HP);
            Assert.AreEqual(0, weaker.HP);
        }
    }
}