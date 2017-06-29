using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPRichEditeBoxTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            var oldActualHeight = PATH_RICH_EDIT_BOX.ActualHeight;
            while (PATH_RICH_EDIT_BOX.ActualHeight <= oldActualHeight)
            {
                PATH_RICH_EDIT_BOX.Document.GetText(Windows.UI.Text.TextGetOptions.None, out string a);
                PATH_RICH_EDIT_BOX.Document.SetText(Windows.UI.Text.TextSetOptions.None, a + "\r");
            }
            
        }

        private void PATH_RICH_EDIT_BOX_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

        }

        private void PATH_RICH_EDIT_BOX_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void PATH_RICH_EDIT_BOX_PointerReleased(object sender, PointerRoutedEventArgs e)
        {

        }

        private void PATH_RICH_EDIT_BOX_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Windows.UI.Text.ITextSelection selectedText =    PATH_RICH_EDIT_BOX.Document.Selection;
            ITextParagraphFormat paragraphFormatting = selectedText.ParagraphFormat;         
            paragraphFormatting.ListType = MarkerType.Arabic;
            selectedText.ParagraphFormat = paragraphFormatting;
        }

        private void PATH_RICH_EDIT_BOX_TextCompositionStarted(RichEditBox sender, TextCompositionStartedEventArgs args)
        {

        }
    }
}
