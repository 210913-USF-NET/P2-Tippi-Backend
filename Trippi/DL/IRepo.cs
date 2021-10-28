﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public interface IRepo
    {
        Task<User> GetOneUserByIdAsync(int id);
        Task<User> GetOneUserByUsernameAsync(string username);
        Task<List<User>> GetAllUsersAsync();
        Task<Friends> AddFriendAsync(Friends friend);
        Task<TripInvites> PostInviteAsync(TripInvites invite);
        Task<List<TripInvites>> GetAllTripInvitesAsync();
        Task<TripInvites> UpdateTripInviteAsync(TripInvites invite);
        Task DeleteUserAsync(int id);
        Task<User> CreateUserAsync(User user);
        Task<Trip> CreateTripAsync(Trip trip);
        Task<Trip> GetTripAsync(int id);
        Task DeleteTripAsync(int id);
        Task<List<Trip>> GetAllTripsAsync();
        Task<Rating> GetRatingAsync(int id);
        Task<Rating> CreateRatingAsync(Rating rating);
        Task DeleteRatingAsync(int id);
        Task<List<Rating>> GetAllRatingsAsync();
    }
}
