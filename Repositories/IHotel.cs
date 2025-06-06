﻿using SHMS.DTOs;
using SHMS.Model;

namespace SHMS.Repositories
{
    public interface IHotel
    {
        IEnumerable<Hotel> GetHotels();
        Hotel GetHotelsByManagerId(int managerId);
        Hotel GetHotelById(int id);
        Hotel GetHotelByName(string name);
        Task UpdateHotelAsync(Hotel hotel);
        bool HotelExists(int id);
        Task AddHotelAsync(Hotel hotel);
        Task DeleteHotelAsync(int id);
        IQueryable<Hotel> SearchHotels(string? location, string? amenities);
        Task<IEnumerable<object>> GetHotelsWithAvailableRoomsAsync();
        Task<string> PatchHotelAsync(int id, HotelDTO patch);

    }
}
