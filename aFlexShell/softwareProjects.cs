using static System.Console;
using static Albert.Flex.Windows.Win32IO;
using static Albert.Flex.Windows.ConsoleApp;
using static System.IO.File;
using Albert.Flex.Windows;
namespace aFlexShell
{
	partial class Program
	{
		/// <summary>
		/// Create's a Ruby Programming Project 
		/// </summary>
		static void rubyProject()
		{
			//Create the Logic for the program here 
			CreateLogic("Create a Ruby Project", rubyProject, start, () =>
			{
				//Folder Picker 
				var browser = new FolderBrowser(true);

				if (browser.DirectoryInfo == null)
					ExitProgram(rubyProject, start);


				//Create the folder
				var folder = browser.DirectoryInfo;

				//Type in information 
				Write("Prjoect Name: ");
				var name = ReadLine();


				var project = folder.CreateSubdirectory(name);
				WriteLine($"{name} Folder created");
				CopyTextFileFromFile("sample.rb", folder.FullName, $"{name}.rb"); // Write a Ruby File Here
				WriteLine($"{name}.rb has been created");
				//Exit Program 
				ExitProgram(rubyProject, start);



			});
		}

		/// <summary>
		/// Create's a Python Programming Project 
		/// </summary>
		static void pythonProject()
		{
			CreateLogic("Create a Python Project", pythonProject, start, () =>
			{
				//Folder Picker 
				var browser = new FolderBrowser(true);

				if (browser.DirectoryInfo == null)
					ExitProgram(pythonProject, start);

				//Create the folder
				var folder = browser.DirectoryInfo;

				//Type in information 
				Write("Prjoect Name: ");
				var name = ReadLine();



				var project = folder.CreateSubdirectory(name);
				name.ToLower();
				CopyTextFileFromFile("sample.py", project.FullName, $"{name}.py"); // Write a Python File Here

				WriteLine($"{name}.py has been created");
				WriteLine($"{name} Folder created");






				//Exit Program 
				ExitProgram(pythonProject, start);

			});
		}

		static void typeScriptProject()
		{
			CreateLogic("Create a TypeScript Project", typeScriptProject, start, () =>
			{

				//Folder Picker 
				var browser = new FolderBrowser(true);

				if (browser.DirectoryInfo == null)
					ExitProgram(typeScriptProject, start);

				//Create the folder
				var folder = browser.DirectoryInfo;

				//Type in information 
				Write("Prjoect Name: ");
				var name = ReadLine();



				var project = folder.CreateSubdirectory(name);
				name.ToLower();
				CopyTextFileFromFile("typescript.ts", project.FullName, $"{name}.ts");
				CopyTextFileFromFile("jquery.js", project.FullName, "jquery.js"); //Jquery.js 
				CopyTextFileFromFile("albert.js", project.FullName, "albert.js"); // albert.js
				CopyTextFileFromFile("aanie.js", project.FullName, "aanie.js"); // aaanie.js
				CopyTextFileFromFile("jalbert.js", project.FullName, "jalbert.js"); // jalbert.js

				WriteLine($"{name}.ts has been created");
				WriteLine($"{name} Folder created");

				//Exit Program 
				ExitProgram(pythonProject, start);


			});
		}


	}
}
