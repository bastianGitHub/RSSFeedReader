﻿using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.StoreApps;
using System;
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
using Windows.Web.Syndication;

// Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace RSSFeedReader.Views
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class FeedViewPage : VisualStateAwarePage
    {
        public FeedViewPage()
        {
            this.InitializeComponent();
        }

        ///// <summary>
        ///// Wird aufgerufen, wenn diese Seite in einem Rahmen angezeigt werden soll.
        ///// </summary>
        ///// <param name="e">Ereignisdaten, die beschreiben, wie diese Seite erreicht wurde.
        ///// Dieser Parameter wird normalerweise zum Konfigurieren der Seite verwendet.</param>
        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    // TODO: Seite vorbereiten, um sie hier anzuzeigen.

        //    // TODO: Wenn Ihre Anwendung mehrere Seiten enthält, stellen Sie sicher, dass
        //    // die Hardware-Zurück-Taste behandelt wird, indem Sie das
        //    // Windows.Phone.UI.Input.HardwareButtons.BackPressed-Ereignis registrieren.
        //    // Wenn Sie den NavigationHelper verwenden, der bei einigen Vorlagen zur Verfügung steht,
        //    // wird dieses Ereignis für Sie behandelt.
        //}

        private void itemGriedView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Zur entsprechenden Zielseite navigieren und die neue Seite konfigurieren,
            //// indem die erforderlichen Informationen als Navigationsparameter übergeben werden
            //var itemId = ((SyndicationItem)e.ClickedItem).ItemUri;
            //this.Frame.Navigate(typeof(NewsViewPage), itemId);


            NavigationService.Navigate("NewsView", sender);
        }
    }
}
