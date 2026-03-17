using ContaOnline.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContaOnline.Testes
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void UsuarioValidarNome()
        {
            var usuario = new Usuario()
            {
                Nome = "Teste",
                Email = "teste@teste.com.br",
                Id = "1",
                Senha = "123456"
            };

            var erros = usuario.Validar();
            Assert.AreEqual(1, erros.Count, "Deveria retornar 1 erro");
        }

        [TestMethod]
        public void UsuarioValidarSenha()
        {
            var usuario = new Usuario()
            {
                Nome = "Teste",
                Email = "teste@teste.com.br",
                Id = "1",
                Senha = "123456"
            };

            var erros = usuario.Validar();
            Assert.AreEqual(1, erros.Count, "Deveria retornar 1 erro");
            Assert.AreEqual(1, erros[0], "A senha deveria ter no minimo 5 caracteres","Mensagem esta errada");
        }
    }
}
