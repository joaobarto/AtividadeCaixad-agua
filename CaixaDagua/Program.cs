Console.WriteLine("A boia A está cheia? (sim/não)");
		string resposta1 = Console.ReadLine().ToLower();
		
		Console.WriteLine("A boia B está cheia? (sim/não)");
		string resposta2 = Console.ReadLine().ToLower();
		
		Console.WriteLine("A boia C está cheia? (sim/não)");
		string resposta3 = Console.ReadLine().ToLower();
		
		if (resposta1 == "não" && resposta2 == "não" && resposta3 == "não")
		{
			Console.WriteLine("Ligar válvula da COPASA!");
		}
		else if (resposta1 == "não" && resposta2 == "não" && resposta3 == "sim")
		{
			Console.WriteLine("Ligar válvula da COPASA!");
		}
		else if (resposta1 == "não" && resposta2 == "sim" && resposta3 == "não")
		{
			Console.WriteLine("Algo está errado, chame um técnico!");
		}
		else if (resposta1 == "não" && resposta2 == "sim" && resposta3 == "sim")
		{
			Console.WriteLine("Algo está errado, chame um técnico!");
		}
		else if (resposta1 == "sim" && resposta2 == "não" && resposta3 == "não")
		{
			Console.WriteLine("Ligar válvula da COPASA e a bomba!");
		}
		else if (resposta1 == "sim" && resposta2 == "não" && resposta3 == "sim")
		{
			Console.WriteLine("Ligar válvula da COPASA!");
		}
		else if (resposta1 == "sim" && resposta2 == "sim" && resposta3 == "não")
		{
			Console.WriteLine("Ligar a bomba!");
		}
		else
		{
			Console.WriteLine("Os reservátorios e caixa d'água estão cheios!");
		}