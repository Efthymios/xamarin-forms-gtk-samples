﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace ClassHierarchy.GTK
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("ClassHierarchy");
            window.Show();
            Gtk.Application.Run();
        }
    }
}