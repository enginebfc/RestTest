using RestTest.Interfaces;
using WebApi.Models;

namespace RestTest.Repositories
{
    public class HiRepository : IHiRepository
    {
        public HiModel Get(int id)
        {
            return new HiModel {Id = 1, Name = "1 model"};
        }

        public int Add(HiModel model)
        {
            return model.Id;
        }
    }
}