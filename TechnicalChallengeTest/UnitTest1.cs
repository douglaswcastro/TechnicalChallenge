using NUnit.Framework;
using System.Collections.Generic;
using TechnicalChallenge.Models;
using TechnicalChallenge.Codes;
using System.Linq;


namespace TechnicalChallengeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
       
        [Test]
        public void VerificaPrimo()
        {
            
            Assert.IsTrue(Calculo.IsNumeroPrimo(5));
        }

        [Test]
        public void VerificaNaoPrimo()
        {
            
            Assert.IsFalse(Calculo.IsNumeroPrimo(10));
        }

        [Test]
        public void VerificaNumerosUnicos()
        {
            
            Assert.That(Calculo.GetDivisores(45).Distinct().ToList(), Is.Unique);
        }

        [Test]
        public void VerificaNumeros()
        {
            List<int> numeroscertos = new List<int> { 1, 3, 5, 9, 15, 45 };
            List<int> numeros = Calculo.GetDivisores(45).Select(n => n.Numero).Distinct().ToList();
            Assert.That(numeros, Is.EquivalentTo(numeroscertos));
        }
    }
}