using WebApi.Models;

namespace RestTest.Interfaces
{
    public interface IHiRepository
    {
        HiModel Get(int id);
        int Add(HiModel model);
    }
}