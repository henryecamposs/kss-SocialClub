using kss_DataObjects.Entities;
using KSS_DataObjects.kss_SocialClub.Capas.Entidades.Entities.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kss_SocialCLubTest
{
    [TestClass]
    public class Testkss_DataObject_Validate
    {
        

        [TestMethod]
        public void validarUsuario_usuariosentity_errorAlValidar ()
        {
            //Arrange
            usuarios usuario = new usuarios();
            usuario.usuario = "";
            usuario.password = "1234";
            usuario.id_nivelAcceso = -1;

            // Act
            var validationResult = ValidationHelper.ValidateEntity<usuarios>(usuario);

            // Assert
            Assert.IsTrue(validationResult.HasError);
            Assert.AreEqual(3, validationResult.Errors.Count);
            Assert.AreEqual("El valor mínimo requerido es 1. Por favor corregir este valor.", validationResult.Errors[0].ErrorMessage);
        }

    }

    
}
