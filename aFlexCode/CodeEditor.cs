using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Albert.Flex.Windows;
using static Albert.Flex.Windows.Win32IO;
using ICSharpCode.AvalonEdit;
using System.IO;
using static System.IO.File;
using aFlexCode.View;
namespace aFlexCode
{
	public class CodeEditor : TextEditor
	{
		//Field's 
		string filter = "All Formats(.)|*.*";

		/// <summary>
		/// DefaultConstructor 
		/// </summary>
		public CodeEditor()
		{
			//Setup Default Commands


			//Open Command
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Open,
		Open_Command));

			//Save Command
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Save,
		Save_Command));

			//Save As Command 
			CommandBindings.Add(new CommandBinding(DesktopCommands.SaveAs,
		SaveAs_Command));

		}

		public CodeEditor(DocumentTabItem _editTab)
		{
			//Setup TabItem
			TabItem = _editTab;

			//Open Command
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Open,
		Open_Command));

			//Save Command
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Save,
		Save_Command));

			//Save As Command 
			CommandBindings.Add(new CommandBinding(DesktopCommands.SaveAs,
		SaveAs_Command));

		}
		void Open_Command(object sender, ExecutedRoutedEventArgs e)
		{



			//Create an OpenDialog Lamba 
			OpenDialogTask("Open a Text File", App.ViewModel.TextFilter, (d) =>
				{

					//Load Text
					Text = ReadAllText(d.FileName);


					//Link the file info 
					FileInfo = new FileInfo(d.FileName);
					CurrentFile = d.FileName;

					if (TabItem != null)
					{
						TabItem.Header = FileInfo.Name;
					}




				});


			//Show the OpenBox 
			//openBox.Show();
		}


		void Save_Command(object sender, ExecutedRoutedEventArgs e)
		{
			if (CurrentFile != null)
			{
				//Write to the Current Text File 
				WriteAllText(CurrentFile, Text);

				if (TabItem != null && FileInfo != null)
				{
					TabItem.Header = FileInfo.Name;
				}
			}
			else if (CurrentFile == null)
			{
				//Use the SaveDialog Box
				SaveDialogTask("Save the Text File", filter, (d) =>
				{
					//Write to the Current Text File 
					WriteAllText(d.FileName, Text);
					//Gather the file Info
					FileInfo = new FileInfo(d.FileName);
					//Setup the  Currnt File 
					CurrentFile = d.FileName;

					if (TabItem != null && FileInfo != null)
					{
						TabItem.Header = FileInfo.Name;
					}
				});
			}
		}
		void SaveAs_Command(object sender, ExecutedRoutedEventArgs e)
		{
			// Use a SaveDialog Box 
			SaveDialogTask("Save the Text File", filter, (d) =>
			{
				//Write to the Current Text File 
				WriteAllText(d.FileName, Text);
				
				//Gather the file Info
				FileInfo = new FileInfo(d.FileName);
				
				//Setup the  Currnt File 
				CurrentFile = d.FileName;

				//TabItem
				if (TabItem != null && FileInfo != null)
				{
					TabItem.Header = FileInfo.Name;
				}
			});
		}

		public FileInfo FileInfo { get; set; }

		public string CurrentFile { get; set; }

		public DocumentTabItem TabItem { get; set; }

	}
}
