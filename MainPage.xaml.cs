using Microsoft.Maui.Controls;
using HNViewer.Controllers;
using HNViewer.Models;
using HNViewer.ViewModel;
using System;

namespace HNViewer;

public partial class MainPage : ContentPage
{

	#region Data Members
	private HNViewerStoryController controller;
	private StoryList Stories;
	#endregion

	public MainPage()
	{
		InitializeComponent();
		controller = new HNViewerStoryController(this);
		Stories = new StoryList();
		BindingContext = new StoryViewModel();
	}

	protected async void RefreshPageAsync(object sender, EventArgs e)
    {
		this.RefreshButton.IsEnabled = false;
		this.Stories = await this.controller.RefreshStories();
		BindingContext = new StoryViewModel(this.Stories);
		Console.WriteLine("Updated UI");
		this.RefreshButton.IsEnabled = true;
    }
}


