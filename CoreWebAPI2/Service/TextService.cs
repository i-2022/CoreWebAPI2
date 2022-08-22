using CoreWebAPI2.Interface;
using CoreWebAPI2.Model;

namespace CoreWebAPI2.Service
{
    public class TextService
    {
        private readonly ITextRepository<Text> _text;

        public TextService(ITextRepository<Text> tetx)
        {
            _text = tetx;
        }
        public Text GetTextById(long Id)
        {
            return _text.GetAll().Where(x => x.TextId == Id).First();
        }
        public IEnumerable<Text> GetAllText()
        {
            try
            {
                return _text.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        
    }
}