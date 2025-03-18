using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enzo_Furtini_DR2_TP1
{
	using System;
	class EntradaUsuario
	{
		static void Main()
		{
			Console.Write("Digite sua cidade: "); string cidade = Console.ReadLine();
			Console.WriteLine($"Você mora em {cidade}!");
		}
	}

}
