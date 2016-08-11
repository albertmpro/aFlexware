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
		/// Create a WordPress Theme folder with all the basic files needed
		///</summary>
		static void wordpressTheme()
		{
			//Create the Logic 
			CreateLogic("Create a WordPress Theme Folder", wordpressTheme, start, () =>
			{
				//Type in the information 
				Write("Name: ");
				var name = ReadLine(); // Name of the theme
				Write("Aurthor: "); // Author of the theme 
				var author = ReadLine();
				Write("Version: "); // Version of the Theme 
				var version = ReadLine();

				var f = new FolderBrowser(true);
				if (f.DirectoryInfo == null)
					ExitProgram(wordpressTheme, start);


				var directory = f.DirectoryInfo; //Grab the selected folder 

				// Create a theme directory 
				var td = directory.CreateSubdirectory(name); // Theme Directory Created 

				//Create some sub folders 
				var img = td.CreateSubdirectory("images"); // Images folder 
				var js = td.CreateSubdirectory("js"); // JavasScript folder 
				var sy = td.CreateSubdirectory("style");// style folder

				//Add to the them directory 
				//File dump 
				var style = $"/*\n\nTheme Name:{name}\nAuthor:{author}\nVersion:{version}\n\n*/"; //Basic style 

				//Write style.css and style.scss
				WriteAllText("style.scss", style);

				// Create the theme folder 																													   
				CopyTextFileFromFile("jquery.js", js.FullName, "jquery.js"); // Write a JQuery File
				CopyTextFileFromFile("albert.js", js.FullName, "albert.js"); // Write alebrt.js
				CopyTextFileFromFile("apage.js", js.FullName, "apage.js"); // Write aPage.js
				CopyTextFileFromFile("jalbert.js", js.FullName, "jalbert.js"); // Write jAlbert.js
				CopyTextFileFromFile("flex.scss", sy.FullName, "flex.scss"); // Write flex.scss
				CopyTextFileFromFile("flexui.scss", sy.FullName, "flexui.scss"); // Write flex.scss

				CopyTextFileFromFile("style.scss", td.FullName, "style.scss"); // Write style.scss
				CopyTextFileFromFile("style.scss", td.FullName, "style.css"); // Write style.css
				CopyTextFileFromFile("wpindex.php", td.FullName, "index.php"); // Write index.php
				CopyTextFileFromFile("wpheader.php", td.FullName, "header.php"); //Write header.php
				CopyTextFileFromFile("wpfooter.php", td.FullName, "footer.php"); //Write footer.php
				CopyTextFileFromFile("wpcontent.php", td.FullName, "content.php"); // Write content.php;
				CopyTextFileFromFile("wppage.php", td.FullName, "page.php"); //Write page.php;
				CopyTextFileFromFile("wpfunctions.php", td.FullName, "functions.php"); //Write functions.php;

				WriteLine("All files have been written...");
				// Go to the exit program 
				ExitProgram(wordpressTheme, start);





			});











		}
		/// <summary>
		/// Create a WordPress Plugin with all the basic files needed 
		/// </summary>
		static void wordpressPlugin()
		{
			//Create the Program 
			CreateLogic("Create a WordPress Plugin Folder", wordpressPlugin, start, () =>
			{
				//Type in the information 
				Write("Name: "); // Name of the Plugin
				var name = ReadLine();
				Write("Aurthor: "); // Author of the Plugin
				var author = ReadLine();
				Write("Version: "); // Version of the Plugin 
				var version = ReadLine();
				Write("License: "); // Lincense of the Plugin 
				var license = ReadLine();

				//Find the WordPress Themes folder to place it in 
				var f = new FolderBrowser(true);


				if (f.DirectoryInfo == null)
					ExitProgram(wordpressPlugin, start);

				var directory = f.DirectoryInfo;
				// Create the Plugin Directory 
				var td = directory.CreateSubdirectory(name); // Theme Directory Created 
															 //Add Sub Folder's to the Directory 
				var img = td.CreateSubdirectory("images"); // Images folder 
				var js = td.CreateSubdirectory("js"); // JavasScript folder 
				var sy = td.CreateSubdirectory("style");// style folder

				//Add to the them directory 
				//File dump 
				var plugininfo = $"<?php\n\n/*\nPlugin Name: {name}\nAuthor: {author}\nVersion: {version}\nLicense: {license}\n\n?>"; // Let WordPress know
																																	  //Write style.css and style.scss
				WriteAllText("functions.php", plugininfo);

				// Create the theme folder 																													   
				CopyTextFileFromFile("jquery.js", js.FullName, "jquery.js"); // Write a JQuery File
				CopyTextFileFromFile("albert.js", js.FullName, "albert.js"); // Write alebrt.js
				CopyTextFileFromFile("apage.js", js.FullName, "apage.js"); // Write aPage.js
				CopyTextFileFromFile("jalbert.js", js.FullName, "jalbert.js"); // Write jAlbert.js
				CopyTextFileFromFile("flex.scss", sy.FullName, "flex.scss"); // Write flex.scss
				CopyTextFileFromFile("flexui.scss", sy.FullName, "flex.scss"); // Write flex.scss
				CopyTextFileFromFile("gwfonts.scss", sy.FullName, "gwfonts.scss"); // Write gwfonts
				CopyTextFileFromFile("style.scss", td.FullName, "style.scss"); // Write style.scss
				CopyTextFileFromFile("style.scss", td.FullName, "style.css"); // Write style.css
				CopyTextFileFromFile("wpfunctions.php", td.FullName, "functions.php"); //Write functions.php;

				WriteLine("All files have ben written...");
				// Go to the exit program 
				ExitProgram(wordpressPlugin, start);

			});

		}


	}
}
