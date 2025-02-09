﻿using BookingApp.Core.Entitis;

namespace BookingApp.Core.Repositories
{
    public interface IUnitOfWork
    {
        IGymClassRepository GymClassRepository { get; }
        IApplicationUserGymRepository UserGymRepository { get; }

        Task CompleteAsync();

    }
}