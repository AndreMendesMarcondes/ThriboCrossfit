using System.Collections.Generic;
using System.Linq;
using TC.Data.Repository.Interfaces;
using TC.Domain;

namespace TC.Data.Repository.Impl
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly MainDb _db;

        public AlunoRepository(MainDb db)
        {
            _db = db;
        }

        public List<Aluno> Get()
        {
            return _db.Alunos.ToList();
        }

        public Aluno GetById(int alunoId)
        {
            return _db.Alunos.FirstOrDefault(c => c.IdAluno == alunoId);
        }

        public void Post(Aluno aluno)
        {
            _db.Alunos.Add(aluno);
            _db.SaveChanges();
        }

        public Aluno Update(int alunoId, Aluno aluno)
        {
            var alunoEntity = GetById(alunoId);

            if (alunoEntity != null)
            {
                alunoEntity.Nome = aluno.Nome;
                alunoEntity.CPF = aluno.CPF;

                _db.Alunos.Update(aluno);
                _db.SaveChanges();
            }

            return aluno;
        }

        public void Delete(int alunoId)
        {
            var alunoEntity = GetById(alunoId);

            if (alunoEntity != null)
            {
                _db.Alunos.Remove(alunoEntity);
                _db.SaveChanges();
            }
        }
    }
}
