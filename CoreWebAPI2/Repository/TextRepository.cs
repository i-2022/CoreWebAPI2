using CoreWebAPI2.Data;
using CoreWebAPI2.Interface;
using CoreWebAPI2.Model;

namespace CoreWebAPI2.Repository
{
    public class TextRepository : ITextRepository<Text>
    {
        ApplicationDbContext _dbContext;
        public TextRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public IEnumerable<Text> GetAll()
        {
            return GetAll(_dbContext);
        }
        public IEnumerable<Text> GetAll(ApplicationDbContext _dbContext)
        {
            try
            {
                return _dbContext.TextTable.ToList();
            }
            catch (Exception ee)
            {
                Console.WriteLine("Application error : " + ee);
                throw;
            }
        }
        public Text GetById(long Id)
        {
            try
            {
                return _dbContext.TextTable
                 .FirstOrDefault(e => e.TextId == Id);
            }
            catch (Exception ee)
            {
                Console.WriteLine("Application error : " + ee);
                throw;
            }
        }
    }
}
