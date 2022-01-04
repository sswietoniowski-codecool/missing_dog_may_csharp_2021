using System;
using Codecool.MissingDog.Model;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.MissingDog.Repository
{
    /// <summary>
    ///     Provides all needed methods on dogs data.
    /// </summary>
    public class DogRepository
    {
        private DataSource _data { get; set; }

        /// <summary>
        ///     Initiates a new instance of DogRepository based on given DataSource.
        /// </summary>
        /// <param name="data"></param>
        public DogRepository(DataSource data)
        {
            _data = data;
        }

        /// <summary>
        ///     Gets all dogs from data.
        /// </summary>
        /// <returns> IEnumerable of all Dogs instances and nulls. </returns>
        public IEnumerable<Dog> GetAllDogs()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets a specific dog with given Id.
        /// </summary>
        /// <param name="id">dogId</param>
        /// <returns> Dog instance or null. </returns>
        public Dog GetDogById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Counts all dogs that are assigned to an owner of a dog with given Id.
        /// </summary>
        /// <param name="dogId">dogId</param>
        /// <returns> Integer, representing Dogs count. </returns>
        public int GetCountOfDogsForTheOwnerOfDogWithId(int dogId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets phone number of the dog owner with the given Id.
        /// </summary>
        /// <param name="dogId">dogId</param>
        /// <returns> String, representing phone number. </returns>
        public string GetOwnerPhoneNoByDogId(int dogId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets all dogs with a given sociability.
        /// </summary>
        /// <param name="isSociable">isSociable</param>
        /// <returns> IEnumerable of Dogs instances. </returns>
        public IEnumerable<Dog> GetDogsBySociability(bool isSociable)
        {
            throw new NotImplementedException();
        }
    }
}
