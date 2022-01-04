using System;
using System.Collections.Generic;
using NUnit.Framework;
using Codecool.MissingDog.Model;
using Codecool.MissingDog.Repository;

namespace Codecool.MissingDog.UnitTests
{
    [TestFixture]
    public class OwnerRepositoryTest
    {
        private List<Dog> _dogs;
        private List<Owner> _owners;
        private List<Breed> _breeds;
        private DataSource _data;
        private OwnerRepository _ownerRepository;

        [SetUp]
        public void Setup()
        {
            var breed1 = new Breed("Russian Toy", 4, 1);
            var breed2 = new Breed("Welsch Corgi", 3, 2);
            var breed3 = new Breed("Labrador", 2, 3);
            var breed4 = new Breed("Chichuachua", 2, 4);
            var breed5 = new Breed("Basenji", 3, 5);
            var breed6 = new Breed("Beagle", 1, 6);

            var dog1 = new Dog(1, "Max", breed1, null, new DateTime(2019, 5, 1), true, true);
            var dog2 = new Dog(2, "Daisy", breed2, null, new DateTime(2018, 2, 8), false, false);
            var dog3 = new Dog(3, "Molly", breed3, null, new DateTime(2014, 12, 22), false, false);
            var dog4 = new Dog(4, "Charlie", breed4, null, new DateTime(2017, 8, 15), false, true);
            var dog5 = new Dog(5, "Dumpling", breed5, null, new DateTime(2020, 7, 14), true, true);
            var dog6 = new Dog(6, "Lily", breed6, null, new DateTime(2014, 12, 22), false, false);
            var dog7 = new Dog(7, "Buddy", breed1, null, new DateTime(2019, 5, 1), true, true);
            var dog8 = new Dog(8, "Abby", breed2, null, new DateTime(2018, 2, 8), false, false);
            var dog9 = new Dog(9, "Koda", breed3, null, new DateTime(2014, 12, 22), false, false);
            var dog10 = new Dog(10, "Bailey", null, null, new DateTime(2017, 8, 15), false, true);
            var dog11 = new Dog(11, "Duke", null, null, new DateTime(2020, 7, 14), true, true);
            var dog12 = new Dog(12, "Jack", breed4, null, new DateTime(2014, 12, 22), false, false);

            var owner1 = new Owner(1, "Anna", "Norman", "606418231", "annanorman@codecool.com", new List<Dog> { null, dog1, dog2, null });
            var owner2 = new Owner(2, "David", "Miller", "506438269", "davidmiller@codecool.com", new List<Dog> { dog3 });
            var owner3 = new Owner(3, "Abigail", "Wilson", "616421919", "abigailwilson@codecool.com", new List<Dog> { dog4, null, null, dog5 });
            var owner4 = new Owner(4, "Ellen", "Doe", "513411552", "ellendoe@codecool.com", new List<Dog> { dog6, dog7, dog8 });
            var owner5 = new Owner(5, "Eric", "Davis", "684247844", "ericdavis@codecool.com", new List<Dog> { dog9 });
            var owner6 = new Owner(6, "Paul", "Smith", "739294753", "paulsmith@codecool.com", new List<Dog> { dog10, dog11, null });

            dog1.Owner = owner1;
            dog2.Owner = owner1;
            dog3.Owner = owner2;
            dog4.Owner = owner3;
            dog5.Owner = owner3;
            dog6.Owner = owner4;
            dog7.Owner = owner4;
            dog8.Owner = owner4;
            dog9.Owner = owner5;
            dog10.Owner = owner6;
            dog11.Owner = owner6;

            _breeds = new List<Breed> { breed1, breed2, breed3, breed4, breed5, breed6, null };
            _dogs = new List<Dog> { dog1, dog2, dog3, dog4, dog5, dog6, dog7, dog8, dog9, dog10, dog11, dog12, null };
            _owners = new List<Owner> { owner1, owner2, owner3, owner4, owner5, owner6, null };
            _data = new DataSource
            {
                Breeds = _breeds, Dogs = _dogs, Owners = _owners
            };
            _ownerRepository = new OwnerRepository(_data);
        }

        [Test]
        public void TestGetOwnerById()
        {
            var result = _ownerRepository.GetOwnerById(1);
            var expected = _owners[0];

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestGetOwnerByIdWhenNullAndReturnsNull()
        {
            var result = _ownerRepository.GetOwnerById(100);

            Assert.IsNull(result);
        }

        [Test]
        public void TestGetCountOfDogsOfSpecificBreedThisOwnerHas()
        {
            var result = _ownerRepository.GetCountOfDogsOfSpecificBreedThisOwnerHas(1, 1);
            var expected = 1;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestGetCountOfDogsOfSpecificBreedThisOwnerHasWhenNullOwner()
        {
            var result = _ownerRepository.GetCountOfDogsOfSpecificBreedThisOwnerHas(1, 100);
            const int expected = 0;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestCountAverageActivityLevelOfThisOwnersDogs()
        {
            var result = _ownerRepository.CountAverageActivityLevelOfThisOwnersDogs(4);
            const double expected = 2.6666666666666665;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestCountAverageActivityLevelOfThisOwnersDogsWhenNullsInList()
        {
            var result = _ownerRepository.CountAverageActivityLevelOfThisOwnersDogs(3);
            const double expected = 2.5;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestGetOldestDogOfThisOwner()
        {
            var result = _ownerRepository.GetOldestDogOfThisOwner(4);
            var expected = _dogs[5];

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestGetOldestDogOfThisOwnerWhenNullsInList()
        {
            var result = _ownerRepository.GetOldestDogOfThisOwner(6);
            var expected = _dogs[9];

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestCountDogsOfThisOwners()
        {
            var result = _ownerRepository.CountDogsOfThisOwners(4);
            const int expected = 3;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestCountDogsOfThisOwnersWithNullsInList()
        {
            var result = _ownerRepository.CountDogsOfThisOwners(3);
            const int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}
