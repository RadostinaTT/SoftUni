
using NUnit.Framework;


namespace Tests
{
    using FightingArena;
    using System;
    public class ArenaTests
    {
        Warrior firstWarrior;
        Warrior secondWarrior;
        Arena arena;

        [SetUp]
        public void Setup()
        {
            firstWarrior = new Warrior("First", 28, 150);
            secondWarrior = new Warrior("Second", 18, 55);
            arena = new Arena();

        }

        [Test]
        public void ArenaMethodEnrollShouldReturnCorrectCount()
        {
            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);
            Assert.AreEqual(2, arena.Warriors.Count);
            Assert.AreEqual(2, arena.Count);
        }

        [Test]
        public void ArenaMethodEnrollShouldThrowInvalidOperationExceptionIfYouTryToEnrollWarriorWithAlreadyExistingName()
        {
            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);
            var thirdWarrior = new Warrior("Second", 250, 650);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(thirdWarrior));
        }

        [Test]
        [TestCase("InvalidName", "First")]
        [TestCase("Second", "Peter")]
        public void ArenaMethodFightShouldThrowInvalidOperationExceptionIfGivenWarriorNameDoesntExist(string attackerName, string defenderName)
        {
            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerName, defenderName));
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerName, defenderName));
        }

        [Test]
        public void ArenaMethodFightShouldWorkCorrectly()
        {
            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);
            arena.Fight("First", "Second");
            Assert.AreEqual(132, firstWarrior.HP);
            Assert.AreEqual(27, secondWarrior.HP);
        }
    }
}