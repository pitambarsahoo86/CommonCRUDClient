using System.Windows;

namespace CommonCRUDClient
{
    public partial class LabelWithTextbox
    {
        public static readonly DependencyProperty LabelContentProperty = DependencyProperty.Register("LabelContent",
            typeof (string),
            typeof (LabelWithTextbox),
            new PropertyMetadata(OnLabelContentPropertyChanged));


        public static readonly DependencyProperty TextBoxTextProperty =
            DependencyProperty.Register("TextBoxText", typeof (string), typeof (LabelWithTextbox),
                new PropertyMetadata(OnTextBoxTextChanged));


        public LabelWithTextbox()
        {
            InitializeComponent();
        }

        public string TextBoxText
        {
            get { return (string) GetValue(TextBoxTextProperty); }
            set { SetValue(TextBoxTextProperty, value); }
        }

        public string LabelContent
        {
            get { return (string) GetValue(LabelContentProperty); }
            set { SetValue(LabelContentProperty, value); }
        }

        private static void OnTextBoxTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var labelWithTextbox = d as LabelWithTextbox;
            if (labelWithTextbox != null)
            {
                labelWithTextbox.TxtName.Text = e.NewValue.ToString();
            }
        }

        private static void OnLabelContentPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var labelWithTextbox = d as LabelWithTextbox;
            if (labelWithTextbox != null)
            {
                labelWithTextbox.LblName.Content = e.NewValue;
            }
        }
    }
}