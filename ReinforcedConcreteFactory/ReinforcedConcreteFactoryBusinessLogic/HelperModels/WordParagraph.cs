using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.HelperModels
{
    public class WordParagraph
    {
        public List<(string, WordTextProperties)> Texts { get; set; }
        public WordTextProperties TextProperties { get; set; }

    }
}
