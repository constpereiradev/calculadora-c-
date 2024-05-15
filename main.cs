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
		  (" 1 - AdiC'C#o\n 2 - SubtraC'C#o\n 3 - DivisC#o\n 4 - MultiplicaC'C#o\n 5 - Sair");
		  opcao = Convert.ToInt32 (Console.ReadLine ());

		if (opcao != 5)
		  {
			Console.WriteLine ("Informe o primeiro nC:mero: ");
			primeiroNumero = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Informe o segundo nC:mero: ");
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

			Console.WriteLine ($ "O total C) {total}");
		  }

	  }

  }

}
