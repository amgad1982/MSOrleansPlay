using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Data.Repositories;
using Grains.GrainsContracts;
using Orleans;

namespace Grains.GrainsImplementations
{
    public class BoardGrain:Grain,IBoardGrain
    {
        private IRepository<Board> _tBoardRepository;
        public BoardGrain(IRepository<Board> repository)
        {
            _tBoardRepository = repository;
        }
        public Task CreateBoard(string header)
        {
            return Task.Run(()=>
            {
                _tBoardRepository.Add(new Board
                {
                    BoardHeader = header
                });
            });
        }

        public Task<IList<Board>> GetAllBoards()
        {
            return Task.Run(() => _tBoardRepository.Find());
        }

        public Task<Board> FindById(Guid id)
        {
            return Task.Run(() => _tBoardRepository.Find(x => x.Id == id).FirstOrDefault());
        }

        public Task UpdateBoard(Board board)
        {
            return Task.Run(() => _tBoardRepository.Update(board));
        }
    }
}
