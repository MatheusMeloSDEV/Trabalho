using CLUSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public interface ILiHandler
    {
        bool ContainsLi(string numeroLi);
        void AdicionarLi(LiInfo li);
        void AtualizarLi(string numeroLi, LiInfo liAtualizada);
        void RemoverLi(string numeroLi);
    }
}
