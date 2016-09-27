﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Albert.Flex.Runtime;
using static Albert.Flex.Runtime.AsyncIO;
using static Albert.Flex.Runtime.Device10x;
using Windows.UI;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace aFlexLab.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class SketchLab : Page10x
	{

		//Field's
		SketchViewState state; 
		SketchCanvas sketchCanvas;
		TextBox txtNotes;
		Maps maps;
		WebBrowser webBrowser;
		Viewbox viewbox;
		Grid gridViewBox;
		StackPanel stackStory;
		double tracop = .3;
		/// <summary>
		/// Default Constructor 
		/// </summary>
		public SketchLab()
		{
			this.InitializeComponent();


			//Declare Field's 
			sketchCanvas = new SketchCanvas { DrawThickness = 15, DrawOpacity = .15 }; // Create's the main SketchCanvas 
			txtNotes = new TextBox() {FontSize= 38,  }; // Create's the notes for a storyboard
	
			viewbox = new Viewbox() { Stretch =  Stretch.Uniform }; // Creates a viewbox for storyboard and or sketch 
			gridViewBox = new Grid(); // Grid to hold storyboard and or sketch 
			stackStory = new StackPanel { Margin = new Thickness(15) };

			//cmbType lamba 
			cmbType.SelectionChanged += (sender, e) =>
			{
				switch(cmbType.SelectedIndex)
				{
					case 0:
						State = SketchViewState.Sketch;
						btnCreate.IsEnabled = true;
						break;
					case 1:
						State = SketchViewState.StoryBoard;
						btnCreate.IsEnabled = true;

						break;
					case 2:
						State = SketchViewState.MapTrace;
						btnCreate.IsEnabled = true;

						break;
					case 3:
						State = SketchViewState.WebTrace;
						btnCreate.IsEnabled = true;

						break;
				}
			};
			

			//Default Drawing Size

			State = SketchViewState.Sketch;

			//ColorPicker lamba
			colorPicker.OnColorChanged += (c) =>
			{
				colorPicker.ColorHistory.Add(new ColorModel(c));
				sketchCanvas.DrawBrush = new SolidColorBrush(c);

				//Set limit 
				if (colorPicker.ColorHistory.Count >= 250)
					colorPicker.ColorHistory.Clear();
			};

		}


		async void cmd_Click(object sender, RoutedEventArgs e)
		{
			var cmd = sender as CmdButton;


			switch (cmd.Label)
			{
				case "Draw":
					sketchCanvas.SketchState = SketchState.Draw;
					break;
				case "Line":
					sketchCanvas.SketchState = SketchState.Line;

					break;
				case "Rectangle":
					sketchCanvas.SketchState = SketchState.Rectangle;

					break;
				case "Circle":
					sketchCanvas.SketchState = SketchState.Circle;

					break;
				case "Erase":
					sketchCanvas.SketchState = SketchState.Erase;

					break;
				case "Save":

					// Create a save picker box for this action 
					await SavePickerAsync(App.ViewModel.ImgFilter, "Sketch", async (p, s) =>
					{
						// Save the file type based on the state and file extension 
						switch (State)
						{
							case SketchViewState.Sketch:
								
						
							   sketchCanvas.Opacity = 1;
							   await ExportPngAsync(sketchCanvas, 72); // Save to png format 

								
								
								break;
							case SketchViewState.MapTrace:

							
								sketchCanvas.Opacity = 1;
								await ExportPngAsync(sketchCanvas, 72); // Save to png format 

								sketchCanvas.Opacity = tracop;

								break;
							case SketchViewState.WebTrace:

								
								sketchCanvas.Opacity = 1;
								await ExportPngAsync(sketchCanvas, 72); // Save to png format 

							
								sketchCanvas.Opacity = tracop;

								break;

							case SketchViewState.StoryBoard:
							
								await ExportPngAsync(stackStory, 72); // Save to the png format 
								
							
								break;

					
						}

					});
			
					break;
				case "Clear":

					switch (State)
					{
						case SketchViewState.StoryBoard:
							await MsgShow("Clear", "Do you want to clear this Storyboard?", "Clear", "Cancel", () =>
							{
								txtNotes.Text = "";
								sketchCanvas.Children.Clear();

							});
							break;
						default:
							await MsgShow("Clear", "Do you want to clear this Sketch?", "Clear", "Cancel", () =>
							{
					
								sketchCanvas.Children.Clear();

							});

							break;
							
					}

				
					break;
				default:

					break;
			}

		}

		void trace_Click(object sender, RoutedEventArgs e)
		{
			switch(sketchCanvas.Visibility)
			{
				case Visibility.Visible:
					sketchCanvas.Visibility = Visibility.Collapsed;
					break;
				case Visibility.Collapsed:
					sketchCanvas.Visibility = Visibility.Visible;
					break;
			}
		}
			

		public SketchViewState State
		{
			get { return state; }
			set
			{
				state = value; 
				
				switch(value)
				{
					case SketchViewState.Sketch:
						CleanUp(false);

						sketchCanvas.Width = 1920;
						sketchCanvas.Height = 1080;
						sketchCanvas.Margin = new Thickness(15); //Margin to help put in perspective 
						sketchCanvas.Background = new SolidColorBrush(Colors.White);

						//Setup viewbox 
						viewbox.Child = gridViewBox;
						gridViewBox.Children.Add(sketchCanvas);

						layoutRoot.Children.Add(viewbox);

						sketchCanvas.Opacity = 1;

						break;
					case SketchViewState.StoryBoard:
						CleanUp(false);

						sketchCanvas.Width = 1920;
						sketchCanvas.Height = 1080;
						sketchCanvas.Margin = new Thickness(15); //Margin to help put in perspective 
						sketchCanvas.Background = new SolidColorBrush(Colors.White);


						cmdTrace.IsEnabled = false;
						//Setup viewbox 
						viewbox.Child = gridViewBox;

						//Create StoryBoard
						stackStory.Children.Add(sketchCanvas);
						stackStory.Children.Add(txtNotes);
						cmdTrace.IsEnabled = false;

						sketchCanvas.Opacity = 1;
						gridViewBox.Children.Add(stackStory);

						//Show the viewbox 
						layoutRoot.Children.Add(viewbox);
						break;
					case SketchViewState.MapTrace:
						CleanUp(true); // Clean up the area
						cmdTrace.IsEnabled = true;
						if (maps == null)
							maps = new Maps();


						//Make the sketchCanvas Transparent 
						sketchCanvas.Opacity = .3;
						sketchCanvas.Visibility = Visibility.Collapsed;
						layoutRoot.Children.Add(maps);
						layoutRoot.Children.Add(sketchCanvas);
						break;
					case SketchViewState.WebTrace:
						CleanUp(true);
						cmdTrace.IsEnabled = true;

						if (webBrowser == null)
							webBrowser = new WebBrowser();

						sketchCanvas.Opacity = .3;
						sketchCanvas.Visibility = Visibility.Collapsed;
						layoutRoot.Children.Add(webBrowser);
						layoutRoot.Children.Add(sketchCanvas);
						break;
				}

			}
		}

		void CleanUp(bool _isEnabled)
		{
			layoutRoot.Children.Clear(); //Clear the deck
			gridViewBox.Children.Clear();
			cmdTrace.IsEnabled =  _isEnabled;
		}



	}

	public enum SketchViewState
	{
		Sketch,StoryBoard,MapTrace,WebTrace
	}
}
