// See https://aka.ms/new-console-template for more information
using System;
using Gtk;

class Program
{
    static void Main(string[] args)
    {
        Application.Init();

        // Create a new window
        Window window = new Window("GTK# App");
        window.DeleteEvent += Window_DeleteEvent;

        // Create a label
        Label label = new Label("Hello, GTK#!");

        // Add the label to the window
        window.Add(label);

        // Show all the widgets
        window.ShowAll();

        // Run the main GTK# loop
        Application.Run();
    }

    private static void Window_DeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
    }
}
