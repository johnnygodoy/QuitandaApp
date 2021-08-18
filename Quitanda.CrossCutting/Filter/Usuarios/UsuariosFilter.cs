using Quitanda.CrossCutting.Base;

namespace Quitanda.CrossCutting.Filter.Usuarios
{
    public class UsuariosFilter : BaseFilter
    {
        public UsuariosFilter(string term)
        {
            if (!string.IsNullOrWhiteSpace(term))
                Term = term.ToUpper();
        }
    }
}