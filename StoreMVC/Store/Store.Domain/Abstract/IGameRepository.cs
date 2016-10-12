using System.Collections.Generic;
using Store.Domain.Entities;

namespace Store.Domain.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}