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
        private Point originPoint;
        public MainPage()
        {
            this.InitializeComponent();

            ITextSelection selection = PATH_RICH_EDIT_BOX.Document.Selection;
            selection.StartPosition = 0;
            selection.EndPosition = 0;
            originPoint = new Point();
            selection.GetPoint(HorizontalCharacterAlignment.Left, VerticalCharacterAlignment.Baseline, PointOptions.Start, out originPoint);


            // PATH_RICH_EDIT_BOX.Document.CaretType
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Point point = new Point();
            ITextSelection selection = PATH_RICH_EDIT_BOX.Document.Selection;

            var sta = selection.StartPosition;
            var en = selection.EndPosition;
            selection.GetPoint(HorizontalCharacterAlignment.Left, VerticalCharacterAlignment.Baseline, PointOptions.Start, out point);
            point = new Point(originPoint.X, point.Y);
            var pgformat = selection.ParagraphFormat;
            //  pgformat.ListStyle = MarkerStyle.Plain;
            selection.SetPoint(point, PointOptions.Start, false);
            var start = selection.StartPosition;
            var end = selection.EndPosition;
            PATH_RICH_EDIT_BOX.Document.Selection.SetRange(start, end + 1);
            PATH_RICH_EDIT_BOX.Focus(FocusState.Pointer);


            //var oldActualHeight = PATH_RICH_EDIT_BOX.ActualHeight;
            //while (PATH_RICH_EDIT_BOX.ActualHeight <= oldActualHeight)
            //{
            //    PATH_RICH_EDIT_BOX.Document.GetText(Windows.UI.Text.TextGetOptions.None, out string a);
            //    PATH_RICH_EDIT_BOX.Document.SetText(Windows.UI.Text.TextSetOptions.None, a + "\r");
            //}
            //string tem = "";

            //PATH_RICH_EDIT_BOX.Document.GetText(TextGetOptions.None, out tem);
            //var endpost = tem.Length - 1;
            //PATH_RICH_EDIT_BOX.Document.Selection.SetRange(endpost, endpost);
            //PATH_RICH_EDIT_BOX.Focus(FocusState.Keyboard);
            //  Point point = new Point();
            //  ITextSelection selection = PATH_RICH_EDIT_BOX.Document.Selection;
            //  selection.StartPosition = 0;
            //  selection.GetPoint(HorizontalCharacterAlignment.Left, VerticalCharacterAlignment.Baseline, PointOptions.Start, out point);
            //  selection.ScrollIntoView(PointOptions.Start);
            //  var le = selection.Length;
            //  ITextParagraphFormat pgFormat = selection.ParagraphFormat;
            //  PATH_RICH_EDIT_BOX.Document.GetRange


            //point = new Point(60, point.Y);
            //  selection.SetPoint(point, PointOptions.Start, false);
            //  var ps = selection.StartPosition;


            //  PATH_RICH_EDIT_BOX.Document.Selection.SetRange(ps, ps);
            //  PATH_RICH_EDIT_BOX.Focus(FocusState.Programmatic);

            // selection.Options = SelectionOptions.AtEndOfLine;
            //PATH_RICH_EDIT_BOX.Document.Selection.SetRange(pgFormat.ListStart, pgFormat.ListStart);
            //PATH_RICH_EDIT_BOX.Focus(FocusState.Keyboard);

            //   pgFormat.ListType = MarkerType.Arabic;
            //   pgFormat.RightToLeft = FormatEffect.On;
            //     PATH_RICH_EDIT_BOX.Document.SetDefaultParagraphFormat(pgFormat);
            //var op = selection.Options;
            //    var ps = selection.EndPosition;
            //   var p = selection.StartPosition;

            //ITextParagraphFormat paragraphFormatting = selection.ParagraphFormat;

            //paragraphFormatting.ListType = MarkerType.Arabic;
            //selection.ParagraphFormat = paragraphFormatting;
            //var le = selection.Length;
            //Point point = new Point();
            //selection.GetPoint(HorizontalCharacterAlignment.Left, VerticalCharacterAlignment.Baseline, PointOptions.Start, out point);
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



        }

        private void PATH_RICH_EDIT_BOX_TextCompositionStarted(RichEditBox sender, TextCompositionStartedEventArgs args)
        {

        }
    }
}
