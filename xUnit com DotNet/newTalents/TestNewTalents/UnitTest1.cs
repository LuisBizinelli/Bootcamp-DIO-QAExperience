using newTalents;
using System;
using System.Linq;
using Xunit;
using newTalents;

namespace TestNewTalents
{
	public class UnitTest1
	{
		public Calculadora ConstruirClasse()
		{
			String data = "02/02/2022";
			Calculadora calc = new Calculadora("02/02/2022");

			return calc;
		}
		[Theory]
		[InlineData (1, 2, 3)]
		[InlineData (4, 5, 9)]
		public void TesteSoma(int val1, int val2, int resultado)
		{
			Calculadora calc = ConstruirClasse();

			int resultadoCalculadora = calc.somar(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}

		[Theory]
		[InlineData(1, 2, -1)]
		[InlineData(5, 4, 1)]
		public void TesteSubtrair(int val1, int val2, int resultado)
		{
			Calculadora calc = ConstruirClasse();

			int resultadoCalculadora = calc.subtrair(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}

		[Theory]
		[InlineData(1, 2, 2)]
		[InlineData(4, 5, 20)]
		public void TesteMultiplicar(int val1, int val2, int resultado)
		{
			Calculadora calc = ConstruirClasse();

			int resultadoCalculadora = calc.multiplicar(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}

		[Theory]
		[InlineData(6, 2, 3)]
		[InlineData(5, 5, 1)]
		public void TesteDividir(int val1, int val2, int resultado)
		{
			Calculadora calc = ConstruirClasse();

			int resultadoCalculadora = calc.dividir(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}


		[Fact]
		public void TestarDividirPorZero()
		{
			Calculadora calc = ConstruirClasse();

			Assert.Throws<DivideByZeroException>(
				() => calc.dividir(3, 0));
		}

		[Fact]
		public void TestarHistorico()
		{
			Calculadora calc = ConstruirClasse();

			calc.somar(1, 2);
			calc.somar(3, 7);
			calc.somar(1, 2);
			calc.somar(8, 9);

			var lista = calc.historico();

			Assert.NotEmpty(calc.historico());
			Assert.Equal(3, lista.Count);
		}

	}
}	
