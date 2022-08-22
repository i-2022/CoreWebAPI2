using CoreWebAPI2.Service;
using CoreWebAPI2.Interface;
using CoreWebAPI2.Model;
using Microsoft.AspNetCore.Mvc;

using CoreWebAPI2.Helpers;
namespace CoreWebAPI2.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TextDetailsController : ControllerBase
    {
        private readonly TextService textService;
        private readonly ITextRepository<Text> textRepository;
        public TextDetailsController(ITextRepository<Text> Text, TextService ProductService)
        {
            textService = ProductService;
            textRepository = Text;
        }
        public IEnumerable<Text> GetAll()
        {
            IEnumerable<Text> textall = textService.GetAllText();
            return textall;
        }
        public int GetWordCount([FromBody] TextModel inputText)
        {
            string str = Utils.RemoveHTMLTagsCharArray(inputText.Tekst.ToString());
            int wrd = Utils.CountWords(str);
            return wrd;
        }

        [HttpGet("{id}", Name = "Get")]
        public Text GetById(int Id)
        {
            Text _textData = textService.GetTextById(Id);
            return _textData;
        }
    }
}
