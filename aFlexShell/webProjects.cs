using static System.Console;

using static Albert.Flex.Windows.Win32IO;
using static Albert.Flex.Windows.ConsoleApp;
using static System.IO.File;
using Albert.Flex.Windows;
using System.IO;
using System.Collections.Generic;
namespace aFlexShell
{
	partial class Program
	{
		static string filter = "All Formats(.)|*.*";
		static void webProject()
		{
			CreateLogic("Static WebSite", webProject, start, () =>
			{
				//Type in the information 
				Write("Name: ");
				var name = ReadLine(); // Name of the theme
				Write("Aurthor: "); // Author of the theme 
				var author = ReadLine();
				Write("Version: "); // Version of the Theme 
				var version = ReadLine();

				//Select the directory that you want to use for the project 
				var browser = new FolderBrowser(true);

				if (browser.DirectoryInfo == null)
					ExitProgram(phpProject, start);

				//Grab the selected folder to store your project 
				var folder = browser?.DirectoryInfo;

				//Create the subfolder with the name of the proejct
				var project = folder.CreateSubdirectory($"{name}");

				//Create an image folder 
				var img = project.CreateSubdirectory("images"); // image directory
				var js = project.CreateSubdirectory("js"); // javascript directory
				var style = project.CreateSubdirectory("style"); // style directory 

				//Add to the them directory 
				//File dump 
				var sty = $"/*\n\nTheme Name:{name}\nAuthor:{author}\nVersion:{version}\n\n*/"; //Basic style 

				//Write style.css and style.scss
				WriteAllText("style.scss", sty);


				//Create the basic project files  
				CopyTextFileFromFile("webpage.html", project.FullName, "index.html"); //index.html

				CopyTextFileFromFile("style.scss", project.FullName, "style.scss"); // style.scss
				CopyTextFileFromFile("style.scss", project.FullName, "style.css"); // style.css

				WriteLine("Main Project files created.");

				// Create the JavaScript Directory
				CopyTextFileFromFile("jquery.js", js.FullName, "jquery.js"); //Jquery.js 
				CopyTextFileFromFile("albert.js", js.FullName, "albert.js"); // albert.js
				CopyTextFileFromFile("aanie.js", js.FullName, "aanie.js"); // aaanie.js
				CopyTextFileFromFile("jalbert.js", js.FullName, "jalbert.js"); // jalbert.js
				CopyTextFileFromFile("apage.js", js.FullName, "apage.js"); //apage.js
				CopyTextFileFromFile("typescript.ts", js.FullName, "typescript.ts"); //typescript.ts
				WriteLine("JavaScript and TypeScript files created.");

				//Create the Style(SASS) Directory 
				CopyTextFileFromFile("flexui.scss", style.FullName, "flexui.scss"); //flexui.scss
				CopyTextFileFromFile("flex.scss", style.FullName, "flex.scss"); // flex.scss
				CopyTextFileFromFile("gwfonts.scss", style.FullName, "gwfonts.scss"); //gwfonts.scss
				WriteLine("Style files created");
				WriteLine("Project is ready");


				//Exit the program or start over 
				ExitProgram(webProject, start);






			});
		}
		/// <summary>
		/// Create's a PHP Project 
		/// </summary>
		static void phpProject()
		{
			CreateLogic("PHP Project", phpProject, start, () =>
			{
				//Type in the information 
				Write("Name: ");
				var name = ReadLine(); // Name of the theme
				Write("Aurthor: "); // Author of the theme 
				var author = ReadLine();
				Write("Version: "); // Version of the Theme 
				var version = ReadLine();

				//Select the directory that you want to use for the project 
				var browser = new FolderBrowser(true);

				if (browser.DirectoryInfo == null)
					ExitProgram(phpProject, start);

				//Grab the selected folder to store your project 
				var folder = browser?.DirectoryInfo;

				//Create the subfolder with the name of the proejct
				var project = folder.CreateSubdirectory($"{name}");

				//Create an image folder 
				var img = project.CreateSubdirectory("images"); // image directory
				var js = project.CreateSubdirectory("js"); // javascript directory
				var style = project.CreateSubdirectory("style"); // style directory 

				//Add to the them directory 
				//File dump 
				var sty = $"/*\n\nTheme Name:{name}\nAuthor:{author}\nVersion:{version}\n\n*/"; //Basic style 

				//Write style.css and style.scss
				WriteAllText("style.scss", sty);


				//Create the basic project files  
				CopyTextFileFromFile("phppage.php", project.FullName, "index.php"); //index.php
				CopyTextFileFromFile("phpconfig.php", project.FullName, "config.php"); // config.php
				CopyTextFileFromFile("style.scss", project.FullName, "style.scss"); // style.scss
				CopyTextFileFromFile("style.scss", project.FullName, "style.css"); // style.css

				WriteLine("Main Project files created.");

				// Create the JavaScript Directory
				CopyTextFileFromFile("jquery.js", js.FullName, "jquery.js"); //Jquery.js 
				CopyTextFileFromFile("albert.js", js.FullName, "albert.js"); // albert.js
				CopyTextFileFromFile("aanie.js", js.FullName, "aanie.js"); // aaanie.js
				CopyTextFileFromFile("jalbert.js", js.FullName, "jalbert.js"); // jalbert.js
				CopyTextFileFromFile("apage.js", js.FullName, "apage.js"); //apage.js
				CopyTextFileFromFile("typescript.ts", js.FullName, "typescript.ts"); //typescript.ts
				WriteLine("JavaScript and TypeScript files created.");

				//Create the Style(SASS) Directory 
				CopyTextFileFromFile("flexui.scss", style.FullName, "flexui.scss"); //flexui.scss
				CopyTextFileFromFile("flex.scss", style.FullName, "flex.scss"); // flex.scss
				CopyTextFileFromFile("gwfonts.scss", style.FullName, "gwfonts.scss"); //gwfonts.scss
				WriteLine("Style files created");
				WriteLine("Project is ready");


				//Exit the program or start over 
				ExitProgram(phpProject, start);






			});
		}

		/// <summary>
		/// Method is designed to generate a Html 5 Page Quickly
		/// </summary>
		static void pageGenrator()
		{
			//Page Genrator 
			CreateLogic("Html Page Genrator", pageGenrator, start, () =>
			{
				string description, keywords, author;
				List<string> styleList, scripts;
				psetup(out description, out keywords, out author, out styleList, out scripts);


				var temp = new HtmlTemp(description, keywords, author);
				temp.Styles = styleList;
				temp.Scripts = scripts;
				//Spit out html file 
				WriteLine(temp.ToString());
				//Save Options 
				WriteLine("Export single file = single");
				WriteLine("Export website = site");
				Write("Export as: ");
				var aws = ReadLine();
				if (aws == "single")
				{
					SaveDialogTask("Save single page", filter, (dialog) =>
					{
						File.WriteAllText(dialog.FileName, temp.ToString());
						ExitProgram(pageGenrator, start);
					});
				}
				else if (aws == "site")
				{
					var nf = true; //Name the file bool 
					var los = new List<FileInfo>(); //List of sites  
					while (nf == true)
					{
						WriteLine("Type the name of the file + extenstion");
						Write("File: ");
						var fl = ReadLine();
						Write("Add this file(y/n): ");
						var add = ReadLine();
						if (add == "y")
						{
							los.Add(new FileInfo(fl));
							Write("Add another file(y/n): ");
							var str = ReadLine();

							if (str == "y")
							{
								nf = true;
							}
							else
							{
								nf = false;
							}
						}
						else
						{
							Write("Add another file(y/n): ");
							var str = ReadLine();

							if (str == "y")
							{
								nf = true;
							}
							else
							{
								nf = false;
							}
						}

					}

					if (los.Count <= 0)
					{
						ExitProgram(pageGenrator, start);
					}
					else if (los.Count >= 1)
					{
						var f = new FolderBrowser(true);


						if (f.DirectoryInfo == null)
							ExitProgram(pageGenrator, start);

						var dir = f?.DirectoryInfo;

						foreach (var i in los)
						{
							var path = Path.Combine(dir.FullName, i.Name);
							i.CopyTo(path, true);
						}

						// Go to the  Exit 
						ExitProgram(pageGenrator, start);
					}





				}
				else
				{
					ExitProgram(pageGenrator, start);
				}





			});
		}

		private static void psetup(out string description, out string keywords, out string author, out List<string> styleList, out List<string> scripts)
		{
			//Field's 
			description = "";
			keywords = "";
			author = "";

			//Define desciption of the website
			Write("Description: ");
			description = ReadLine();
			//Define the keywords 
			Write("Keywords: ");
			keywords = ReadLine();
			//Define the Author 
			Write("Author: ");
			author = ReadLine();

			styleList = new List<string>();
			var addStyle = true;

			while (addStyle == true)
			{
				Write("Stylesheet: ");
				var sty = ReadLine();
				styleList.Add(sty);

				Write("Do you want add a another style?(y/n):  ");

				var op = ReadLine();

				if (op == "y")
				{
					addStyle = true;
				}
				else
				{
					addStyle = false;
				}
			}


			scripts = new List<string>();
			var addScript = true;

			while (addScript == true)
			{
				Write("Script: ");
				var sc = ReadLine();
				scripts.Add(sc);

				Write("Do you want add a another script?(y/n):  ");

				var op1 = ReadLine();

				if (op1 == "y")
				{
					addScript = true;
				}
				else
				{
					addScript = false;
				}

			}

			//Create HtmlTemp 
		}
	}
}
