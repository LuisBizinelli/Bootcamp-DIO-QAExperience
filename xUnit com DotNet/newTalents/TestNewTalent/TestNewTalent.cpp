#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace TestNewTalent
{
	TEST_CLASS(TestNewTalent)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			Calculadora calc = new Calculadora();
		}
	};
}
