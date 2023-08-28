using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebAPIAutores.Tests.PruebasUnitarias
{
    [TestClass]
    public class PrimeraLetraMayusculaAttributeTests
    {
        [TestMethod]
        public void PrimeraLetraMinuscula_DevuelveError()
        {
            //Las pruebas se dividen en tres partes
            //Preparacion
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();

            var valor = "felipe";

            var valContext = new ValidationContext(new { Nombre = valor });
            //Ejecucion


            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);
            //Verificacion

            Assert.AreEqual("La primera letra debe ser mayuscula", resultado.ErrorMessage);




        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            //Las pruebas se dividen en tres partes
            //Preparacion
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();

            string? valor = null;

            var valContext = new ValidationContext(new { Nombre = valor });
            //Ejecucion


            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);
            //Verificacion

            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void ValorConPrimeraLetraMayuscula_NoDevuelveError()
        {
            //Las pruebas se dividen en tres partes
            //Preparacion
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();

            string? valor = "Felipe";

            var valContext = new ValidationContext(new { Nombre = valor });
            //Ejecucion


            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);
            //Verificacion

            Assert.IsNull(resultado);
        }











    }
}