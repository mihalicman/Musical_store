﻿namespace ShopWebsite.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);
        int GetUserId();
        string GetUserEmail();
        Task<string> GetUserFullNameAsync(int id);
        Task<User> GetUserByEmail(string email);
        Task<string> GetUserAddress(int id);
    }
}
