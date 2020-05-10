using System.Windows;

namespace CommonCRUDClient
{
    public partial class LabelWithTextbox
    {
        public static readonly DependencyProperty LabelContentProperty = DependencyProperty.Register("LabelContent",
            typeof (string),
            typeof (LabelWithTextbox),
            new PropertyMetadata(OnLabelContentPropertyChanged));

        public LabelWithTextbox()
        {
            InitializeComponent();
        }

        public string LabelContent
        {
            get { return (string) GetValue(LabelContentProperty); }
            set { SetValue(LabelContentProperty, value); }
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