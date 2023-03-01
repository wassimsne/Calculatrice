using NUnit.Framework;
using Calculatrice;
using System;

namespace TestProjectCalculatrice
{
    public class TestCalculSimple
    {
       
        [Test]
        public void TestPlateform()
        {
            Assert.Pass();
        }
        [Test]
        public void Add_ZeroPlusZero_Zero()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 = 0;
            int op2 = 0;
            //Acion 
            var resultat = calcul.add(op1, op2);
            //Assert
            Assert.AreEqual(0, resultat);
        }
        [Test]
        public void Add_unPlusun_deux()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 = 1;
            int op2 = 1;
            //Acion 
            var resultat = calcul.add(op1, op2);
            //Assert
            Assert.AreEqual(2, resultat);
        }    
        [TestCase(5,7,12)]
        [TestCase(20, 3, 23)]
        [TestCase(5, 12, 17)]
        [TestCase(16, 7, 23)]
        public void Add_EntierPlusEntier_Entier(int op1,int op2,int resultatattendu)
        {
            //Arrange 
            var calcul = new CalculSimple();
            //Acion 
            var resultat = calcul.add(op1, op2);
            //Assert
            Assert.AreEqual(resultatattendu, resultat);
        }
        [TestCase(-5, -7, -12)]
        [TestCase(-20, -3, -23)]
        [TestCase(-5, -12, -17)]
        [TestCase(-16, -7, -23)]
        public void Add_EntiernegatifPlusEntiernegatif_Entier(int op1, int op2, int resultatattendu)
        {
            //Arrange 
            var calcul = new CalculSimple();
            //Acion 
            var resultat = calcul.add(op1, op2);
            //Assert
            Assert.AreEqual(resultatattendu, resultat);
        }
        [Test]
        public void Add_MaxintPlusMaxint_ArgumentException()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 = int.MaxValue;
            int op2 = int.MaxValue;
            //Acion 
            var resultat = Assert.Throws<ArgumentException>(()=> calcul.add(op1, op2));
            //Assert
            Assert.NotNull(resultat);
        }
        [Test]
        public void Devide_UnDevUn_Un()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 =1;
            int op2 =1;
            //Acion 
            var resultat = calcul.devide(op1, op2);
            //Assert
            Assert.AreEqual(1, resultat);
        }
        [Test]
        public void Devide_MaxDevUn_Max()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 = int.MaxValue;
            int op2 = 1;

            //Acion 
            var resultat = calcul.devide(op1, op2);
            //Assert
            Assert.AreEqual(int.MaxValue, resultat);
        }
        [Test]
        public void Devide_MaxintDevMaxint_ArgumentException()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 = int.MaxValue;
            int op2 = int.MaxValue;
            //Action 
            var resultat = calcul.devide(op1, op2);
            //Assert
            Assert.AreEqual(1,resultat);
        }
        [Test]
        public void Devide_ZeroDevMaxint_Zero()
        {
            //Arrange 
            var calcul = new CalculSimple();
            int op1 = 0;
            int op2 = int.MaxValue;
            //Action 
            var resultat = calcul.devide(op1, op2);
            //Assert
            Assert.AreEqual(0, resultat);
        }
    }
}