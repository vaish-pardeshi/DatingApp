using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get; }
        IMessagesRepository MessagesRepository { get; }
        ILikesRepository likesRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}