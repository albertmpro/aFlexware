using System;
using System.Collections.Generic;
using static System.Console;
using static Albert.Flex.Windows.Win32IO;
using static Albert.Flex.Windows.ConsoleApp;
using System.IO;
using Albert.Flex.Windows;
namespace aFlexShell
{
	partial class Program
	{
		//static Action program; // This is the varible used to execute the code when nessary 
		static string line = "----------------------------------------------------------";



		[STAThread] // For COM realated things  
		static void Main(string[] args)
		{
			RunProgram(start);
		}

		#region Programs 


		/// <summary>
		/// Default Start Point
		/// </summary>
		static void start()
		{
			//Clear out the console 
			Clear();

			WriteLine("aFlexShell");
			WriteLine();
			WriteLine("Select a Program to run");
			WriteLine(line);
			WriteLine("Export Tool = exp");
			WriteLine("Scripting = script"); // Link to the 
			WriteLine("Web Development = web");
			WriteLine("WordPress Projects = wp");
			WriteLine("About aFlexShell = about");
			WriteLine("Exit = exit");
			WriteLine(line);
			Write("Type what you want to do here: ");
			var str = ReadLine(); // Select the Program 

			switch (str)
			{
				case "exp":
					RunProgram(exportToFolder);
					break;
				case "script":
					RunProgram(scriptingMenu);
					break;
				case "web":
					RunProgram(webMenu);
					break;
				case "wp":
					RunProgram(wpMenu);
					break;
				case "about":
					RunProgram(about);
					break;
				case "exit":
					WriteLine("Goodbye!");
					break;
				default:
					RunProgram(start);
					break;


			}



		}
		/// <summary>
		/// Shows information about the program 
		/// </summary>
		static void about()
		{
			Clear();
			WriteLine(line);
			WriteLine("aFlexShell\nCreated by\nAlbert M. Byrd");
			WriteLine(line);


			ExitProgram(about, start);

		}


		/// <summary>
		/// Scripting Menu 
		/// </summary>
		static void scriptingMenu()
		{
			Clear();

			WriteLine("Script Projects");
			WriteLine();
			WriteLine("Select a Scripting Project to run");
			WriteLine(line);
			WriteLine("Python Project = py");
			WriteLine("TypeScript Project = ts");
			WriteLine("Ruby Project = rb");
			WriteLine("Go back to the Start Menu = start");
			WriteLine(line);
			Write("Type what you want to do here: ");
			var str = Console.ReadLine(); // Select the Program 


			switch (str)
			{
				case "py": // Create a Python Project
					RunProgram(pythonProject);
					break;
				case "rb": // Create a Ruby Project
					RunProgram(rubyProject);
					break;
				case "ts":// Create a TypeScirpt Project
					RunProgram(typeScriptProject);
					break;
				case "start": // Go Back to the Start Menu
					RunProgram(start);
					break;
				default:
					ExitProgram(scriptingMenu, start);
					break;
			}



		}
		/// <summary>
		/// Web Menu 
		/// </summary>
		static void webMenu()
		{
			Clear();

			//Logic Lamba 
			WriteLine("Web Projects");
			WriteLine();
			WriteLine("Select a Scripting Project to run");
			WriteLine(line);
			WriteLine("Simple Web Project = web");
			WriteLine("PHP Project = php");
			WriteLine("Html Page Maker = html");
			WriteLine("Go back to the Start Menu = start");
			WriteLine(line);
			Write("Type what you want to do here: ");
			var str = Console.ReadLine(); // Select the Program 


			switch (str)
			{
				case "web":
					RunProgram(webProject);
					break;
				case "php":
					RunProgram(phpProject);
					break;
				case "html":
					RunProgram(pageGenrator);
					break;
				case "start":
					RunProgram(start);
					break;

				default:
					ExitProgram(webMenu, start);
					break;
			}

		}
		/// <summary>
		/// WordPress Menu 
		/// </summary>
		static void wpMenu()
		{
			Clear();
			WriteLine("WordPress Projects");
			WriteLine();
			WriteLine("Select a WordPress Project to run");
			WriteLine(line);
			WriteLine("WordPress Theme = wpt");
			WriteLine("WordPress = wpp");
			WriteLine("Go back to the Start Menu = start");
			WriteLine(line);
			Write("Type what you want to do here: ");
			var str = Console.ReadLine(); // Select the Program 

			switch (str)
			{
				case "wpt":// Create a WordPress Theme
					RunProgram(wordpressTheme);
					break;
				case "wpp": // Create a Word Press Plugin 

					RunProgram(wordpressPlugin);

					break;
				case "start": // Go to the StartMenu 

					RunProgram(start);

					break;
				default:
					ExitProgram(wpMenu, start);
					break;

			}

		}




		/// <summary>
		/// Export any number file to a specifc folder when nesserary 
		/// </summary>
		static void exportToFolder()
		{
			CreateLogic("Export files to a Folder", exportToFolder, start, () =>
			{

				//Default Filter for the OpenDialog 
				var filter = "All Formsts(.)|*.*";
				var importing = true;
				//List of the Files that have been 
				var fileList = new List<FileInfo>();



				var opt = "";
				// do while importing == true; 
				while (importing == true)
				{

					//Do the OpenDialogTask Lamba 
					OpenDialogTask("Pick your Export Files", filter, (dialog) =>
					{
						if (dialog.FileName != null)
						{
							foreach (var file in dialog.FileNames)
							{
								//Grab the name of each selected file 
								var fi = new FileInfo(file); // Create a file info for them 
								fileList.Add(fi); // Add them to the file list


							}
							foreach (var i in fileList)
							{
								// Show the file name of each item you import 
								WriteLine($"Exported File: {i.Name}");
							}
						}
					});
					// Do you want to add more files? 
					Write("Do you want to export more files?(y/n): ");
					opt = ReadLine();

					if (opt == "y")
					{
						importing = true;
					}
					else
					{
						importing = false;
					}
				}

				if (fileList.Count <= 0)
				{
					// Go to the  Exit 
					ExitProgram(exportToFolder, start);

				}
				else if (fileList.Count >= 1)
				{
					Write("Do you want to copy files to new folder? (y/n): ");
					var rd = ReadLine();

					if (rd == "y")
					{
						var f = new FolderBrowser(true);


						if (f.DirectoryInfo == null)
							ExitProgram(exportToFolder, start);

						var dir = f?.DirectoryInfo;

						foreach (var i in fileList)
						{
							var path = Path.Combine(dir.FullName, i.Name);
							i.CopyTo(path, true);
						}

						// Go to the  Exit 
						ExitProgram(exportToFolder, start);



					}
					else
					{
						// Go to the  Exit 
						ExitProgram(exportToFolder, start);
					}


				}
				else
				{
					ExitProgram(wordpressPlugin, start);
				}

			});




		}













		#endregion

	}
}
