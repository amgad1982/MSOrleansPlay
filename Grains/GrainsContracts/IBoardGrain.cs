using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Orleans;

namespace Grains.GrainsContracts
{
    public interface IBoardGrain:IGrainWithGuidKey
    {
        Task CreateBoard(string header);
        Task<IList<Board>> GetAllBoards();
    }
}
