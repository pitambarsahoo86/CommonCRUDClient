using System.Windows;
using System.Windows.Input;

namespace CommonCRUDClient
{
    public partial class SaveCancelControl
    {
        public static readonly DependencyProperty SaveButtonContentProperty =
            DependencyProperty.Register("SaveButtonContent", typeof (string), typeof (SaveCancelControl),
                new PropertyMetadata(OnSaveButtonContentChanged));

        public static readonly DependencyProperty CancelButtonContentProperty =
            DependencyProperty.Register("CancelButtonContent", typeof (string), typeof (SaveCancelControl),
                new PropertyMetadata(OnCancelButtonContentChanged));

        public static readonly DependencyProperty SaveCommandProperty =
            DependencyProperty.Register("SaveCommand", typeof (ICommand), typeof (SaveCancelControl));

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.Register("ClearCommand", typeof (ICommand), typeof (SaveCancelControl));


        public SaveCancelControl()
        {
            InitializeComponent();
        }

        public ICommand ClearCommand
        {
            get { return (ICommand) GetValue(ClearCommandProperty); }
            set { SetValue(ClearCommandProperty, value); }
        }

        public ICommand SaveCommand
        {
            get { return (ICommand) GetValue(SaveCommandProperty); }
            set { SetValue(SaveCommandProperty, value); }
        }

        public string SaveButtonContent
        {
            get { return (string) GetValue(SaveButtonContentProperty); }
            set { SetValue(SaveButtonContentProperty, value); }
        }

        public string CancelButtonContent
        {
            get { return (string) GetValue(CancelButtonContentProperty); }
            set { SetValue(CancelButtonContentProperty, value); }
        }

        private static void OnSaveButtonContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var saveCancelControl = d as SaveCancelControl;
            if (saveCancelControl != null)
            {
                saveCancelControl.BtnSave.Content = e.NewValue;
            }
        }

        private static void OnCancelButtonContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var saveCancelControl = d as SaveCancelControl;
            if (saveCancelControl != null)
            {
                saveCancelControl.BtnClear.Content = e.NewValue;
            }
        }
    }
}