﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatlaSport.Services.HiveManagement
{
    /// <summary>
    /// Represents a hive service.
    /// </summary>
    public interface IHiveService
    {
        /// <summary>
        /// Gets a hives list.
        /// </summary>
        /// <returns>A <see cref="Task{List}"/>.</returns>
        Task<List<HiveListItem>> GetHives();

        /// <summary>
        /// Gets a hive with specified identifier.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <returns>A <see cref="Task{Hive}"/>.</returns>
        Task<Hive> GetHive(int hiveId);

        /// <summary>
        /// Creates a new hive.
        /// </summary>
        /// <param name="createRequest">A <see cref="UpdateHiveRequest"/>.</param>
        /// <returns>A <see cref="Task{Hive}"/>.</returns>
        Task<Hive> CreateHive(UpdateHiveRequest createRequest);

        /// <summary>
        /// Updates an existed hive.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <param name="updateRequest">A <see cref="UpdateHiveRequest"/>.</param>
        /// <returns>A <see cref="Hive"/>.</returns>
        Task<Hive> UpdateHive(int hiveId, UpdateHiveRequest updateRequest);

        /// <summary>
        /// Deletes an existed hive.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task DeleteHive(int hiveId);

        /// <summary>
        /// Sets deleted status for a hive.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <param name="deletedStatus">Status.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task SetStatus(int hiveId, bool deletedStatus);
    }
}
