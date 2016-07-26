using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Albert.Flex.Windows
{
	/// <summary>
	/// A special class for Event driven Console Applcations 
	/// </summary>
	public static class ConsoleApp
	{
		/// <summary>
		/// Create's a line to seperate text 
		/// </summary>
		public static string Line { get; set; } = "-----------------------------------------------------------";
		/// <summary>
		/// Gets or Set the Active Program 
		/// </summary>
		public static Action Program { get; set; }

		#region Logic 

		/// <summary>
		/// Method help's easy create the program to be used for a Console Application  
		/// </summary>
		/// <param name="_title"> Title of the Program</param>
		/// <param name="_returnMethod">Used to restart the program</param>
		/// <param name="_start">The Start Program </param>
		/// <param name="_logic">Logic of the Program</param>
		public static void CreateLogic(string _title, Action _returnMethod,Action _start, Action _logic)
		{
			Clear();// Clear the console 
			WriteLine(_title);
			WriteLine(Line);
			WriteLine();
			Write("Do you want to start? (y/n): ");
			var st = ReadLine(); // Type here

			if (st == "y")
			{
				//Run the Logic  
				_logic.Invoke();
			}
			else
			{
				ExitProgram(_returnMethod,_start);
			}
		}


		/// <summary>
		/// Load's the code you want to run
		/// </summary>
		/// <param name="_program">the code that you want to run</param>
		public static void RunProgram(Action _program)
		{
			Program = null; // Clear out program 
			Program = _program;
			Program();//RunProgram
		}
		/// <summary>
		/// Gives you an option to exit the code back to the start method 
		/// </summary>
		/// <param name="_program">the current code being run</param>
		public static void ExitProgram(Action _program, Action _startup)
		{
			//Exit 
			Write("Do you want to go back to the start? (y/n): ");
			var aws = Console.ReadLine(); // type in y for yes 

			if (aws == "y" || aws == "Y")
			{
				RunProgram(_startup); // Go to the start code
			}
			else
			{
				RunProgram(_program); // run the program code again 
			}
		}


		#endregion


	}
}
