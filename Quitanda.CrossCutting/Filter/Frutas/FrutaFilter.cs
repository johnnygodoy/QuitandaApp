using Quitanda.CrossCutting.Base;

namespace Quitanda.CrossCutting.Filter
{
    public class FrutaFilter : BaseFilter
    {
        public FrutaFilter(string term)
        {
            if (!string.IsNullOrWhiteSpace(term))
                Term = term.ToUpper();
        }
    }
}