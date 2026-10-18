using PruebasUnitariasApp;

namespace TestPruebasUnitarias
{
    [TestClass]
    public sealed class ValidadorUsuarioTest
    {

        [TestMethod]
        public void Factorial_Numero_negativo()
        {
            int result = ValidadorUsuario.CalcularFactorial(-5);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Factorial_Cero()
        {
            int result = ValidadorUsuario.CalcularFactorial(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Factorial_Correcto()
        {
            int result = ValidadorUsuario.CalcularFactorial(5);
            Assert.AreEqual(120, result);
        }

        ////

        [TestMethod]
        public void Contrasenya_Null()
        {
            bool result = ValidadorUsuario.EsContrasenyaValida(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Contrasenya_Vacia()
        {
            bool result = ValidadorUsuario.EsContrasenyaValida("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Contrasenya_Corta()
        {
            bool result = ValidadorUsuario.EsContrasenyaValida("qwe#");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Contrasenya_Valida()
        {
            bool result = ValidadorUsuario.EsContrasenyaValida("Contraseña#");
            Assert.IsTrue(result);
        }


    }
}
