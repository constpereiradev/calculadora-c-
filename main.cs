using System;
class HelloWorld
{

  static void Main ()
  {
	int opcao = 0;
	while (opcao != 5)
	  {
		int primeiroNumero = 0;
		int segundoNumero = 0;
		int total = 0;

		  Console.WriteLine ("---------- Calculadora ----------");
		  Console.
		  WriteLine
		  (" 1 - Adição\n 2 - Subtração\n 3 - Divisão\n 4 - Multiplicação\n 5 - Sair");
		  opcao = Convert.ToInt32 (Console.ReadLine ());

		if (opcao != 5)
		  {
			Console.WriteLine ("Informe o primeiro número: ");
			primeiroNumero = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Informe o segundo número: ");
			segundoNumero = Convert.ToInt32 (Console.ReadLine ());

			switch (opcao)
			  {
			  case 1:
				total = primeiroNumero + segundoNumero;
				break;
				case 2:total = primeiroNumero - segundoNumero;
				break;
				case 3:total = primeiroNumero / segundoNumero;
				break;
				case 4:total = primeiroNumero * segundoNumero;
				break;
				case 5:break;
				default:Console.WriteLine ("OpC'C#o nC#o reconhecida.");
				break;
			  }

			Console.WriteLine ($"O total é: {total}");
		  }

	  }

  }

}
