using NUnit.Framework;
using PersistenceLayer.Infrastructure.Database;
using PersistenceLayer.Models;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Save()
        {
            var aula = this.CreatObj<Aula>();
            aula.Tema = "EF Core";
            aula.Descricao = "Implementando persistência com EF Core";

            var aulas = new EFCoreDatabase<Aula>();
            aulas.Save(aula);

            Assert.AreEqual(aula.Id, aulas.GetByIdAsync(aula.Id).Result.Id, "Deu bão jovi");
        }

        [Test]
        public void Get()
        {
            var aulas = new EFCoreDatabase<Aula>();
            var aula = aulas.GetByIdAsync(5).Result;
            Assert.NotNull(aula, "Falha ao encontrar o objeto no banco de dados");
        }
        [Test]
        public void Remove()
        {
            var aulas = new EFCoreDatabase<Aula>();
            aulas.Remove(19);
            var aulaDeletada = aulas.GetByIdAsync(19).Result;
            Assert.Null(aulaDeletada);
        }

        [Test]
        public void Update()
        {
            var aulas = new EFCoreDatabase<Aula>();
            var aulaParaAtualizar = aulas.GetByIdAsync(27).Result;
            aulaParaAtualizar.Tema = "Novo Tema Update";
            aulas.Update(aulaParaAtualizar);
            var aulaAtualizada = aulas.GetByIdAsync(aulaParaAtualizar.Id).Result;
            Assert.AreEqual("Novo Tema Update", aulaAtualizada.Tema);
        }



        public Entity CreatObj<Entity>()
        {
            return Activator.CreateInstance<Entity>();
        }

    }
}