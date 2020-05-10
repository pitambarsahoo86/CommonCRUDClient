using System.Windows;

namespace CommonCRUDClient
{
    public partial class LabelAndComboBox
    {
        public static readonly DependencyProperty LabelContentProperty =
            DependencyProperty.Register("LabelContent", typeof (string), typeof (LabelAndComboBox),
                new PropertyMetadata(OnLabelConentChanged));

        public LabelAndComboBox()
        {
            InitializeComponent();
        }

        public string LabelContent
        {
            get { return (string) GetValue(LabelContentProperty); }
            set { SetValue(LabelContentProperty, value); }
        }

        private static void OnLabelConentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var labelAndComboBox = d as LabelAndComboBox;
            if (labelAndComboBox != null)
            {
                labelAndComboBox.LblName.Content = e.NewValue;
            }
        }
    }
}