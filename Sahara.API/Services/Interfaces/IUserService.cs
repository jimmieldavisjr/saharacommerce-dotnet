using Sahara.API.Entities;

namespace Sahara.API.Services.Interfaces
{
    /// <summary>
    /// Defines operations for managing user profiles.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Updates the user's profile.
        /// </summary>
        /// <param name="user">The user entity with optional updated values.</param>
        /// <returns>The updated user entity.</returns>
        Task<User> UpdateProfile(User user);

        /// <summary>
        /// Soft deletes the user marking it as deleted (IsDeleted = true).
        /// </summary>
        /// <param name="user"></param>
        /// <returns>The soft deleted user entity with updated (IsDeleted) property.</returns>
        Task<User> SoftDelete(User user);
    }
}
