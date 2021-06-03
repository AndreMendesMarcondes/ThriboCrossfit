using System.Collections.Generic;
using TC.Domain;

namespace TC.Data.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> Get();
        Aluno GetById(int alunoId);
        void Post(Aluno aluno);
        Aluno Update(int alunoId, Aluno aluno);
        void Delete(int alunoId);
    }
}
